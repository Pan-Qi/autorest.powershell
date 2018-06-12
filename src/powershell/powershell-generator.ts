import { Model } from '#common/code-model/code-model';
import { execute, resolveFullPath } from '#common/exec';
import { resources } from '#common/locations';
import { copyResources } from '#common/utility';
import { deserialize, serialize } from '#common/yaml';
import { Host } from '@microsoft.azure/autorest-extension-base';
import { join } from 'path';
import { Project } from './project';
import { State, GeneratorSettings } from './state';

let _settings: GeneratorSettings | undefined;
async function settings(service: Host): Promise<GeneratorSettings> {

  return _settings || (_settings = {
    azure: await service.GetValue('azure') || await service.GetValue('azure-arm') || false,
    cmdletFolder: await service.GetValue('cmdlet-folder') || 'cmdlets/generated',
    customFolder: await service.GetValue('custom-cmdlet-folder') || 'cmdlets/custom',
    runtimefolder: await service.GetValue('runtime-folder') || 'runtime',
    apifolder: await service.GetValue('api-folder') || './',
    moduleName: await service.GetValue('module-name') || '',
    csproj: await service.GetValue('csproj') || '',
    psd1: await service.GetValue('psd1') || '',
    psm1: await service.GetValue('psm1') || '',
  });
}

async function wait(items: Iterable<Promise<void>>) {
  await Promise.all([...items]);
}
export async function processRequest(service: Host) {
  try {
    // Get the list of files
    const files = await service.ListInputs('code-model-v2');
    if (files.length === 0) {
      throw new Error('Inputs missing.');
    }

    const cfg = await settings(service);
    const codemodel = files[0];

    // get the openapi document
    const codeModelText = await service.ReadFile(codemodel);
    const model = await deserialize<Model>(codeModelText, codemodel);

    cfg.moduleName = cfg.moduleName || model.info.title.replace(/client/ig, '');
    cfg.csproj = cfg.csproj || `${cfg.moduleName}.private.csproj`;
    cfg.psd1 = cfg.psd1 || `${cfg.moduleName}.psd1`;
    cfg.psm1 = cfg.psm1 || `${cfg.moduleName}.psm1`;

    await service.ProtectFiles(cfg.csproj);
    await service.ProtectFiles(cfg.customFolder);
    // await service.ProtectFiles(cfg.psm1);
    // await service.ProtectFiles(cfg.psd1);

    // generate some files
    const modelState = new State(service, model, codemodel);
    const project = new Project(modelState, cfg);
    await project.writeFiles(async (filename, content) => service.WriteFile(filename, content, undefined, 'source-file-csharp'));

    // wait for all the generation to be done
    await generateCsproj(service);
    await copyRuntime(service);
    await generateCsproj(service);
    await generateModule(service, project);
    // await generateProxies(service);

    // debug data
    service.WriteFile('code-model-v2.powershell.yaml', serialize(model), undefined, 'source-file-other');

  } catch (E) {
    console.error(E);
  }
}


async function generateProxies(service: Host) {
  const cfg = await settings(service);
  const of = await service.GetValue('output-folder');

  // find the pwsh executable.
  const pwsh = await resolveFullPath('pwsh', process.platform === 'win32' ? ['c:/Program Files/PowerShell', 'c:/Program Files (x86)/PowerShell'] : []);
  if (!pwsh) {
    // no powershell core found.
    throw new Error("PowerShell Core (pwsh) not found in path. Please ensure that pwsh is available.");
  }

  console.error(`${pwsh} -command "${of}/generate_proxies.ps1"`);

}

async function copyRuntime(service: Host) {
  const cfg = await settings(service);

  await copyResources(join(resources, 'scripts', 'powershell'), async (fname, content) => service.WriteFile(fname, content, undefined, 'source-file-csharp'));

  await copyResources(join(resources, 'runtime', 'powershell'), async (fname, content) => service.WriteFile(join(cfg.runtimefolder, fname), content, undefined, 'source-file-csharp'));
  if (cfg.azure) {
    await copyResources(join(resources, 'runtime', 'powershell.azure'), async (fname, content) => service.WriteFile(join(cfg.runtimefolder, fname), content, undefined, 'source-file-csharp'));
  }
}

async function generateCsproj(service: Host) {
  const cfg = await settings(service);

  // write out the csproj file if it's not there.
  if (!await service.ReadFile(cfg.csproj)) {
    service.WriteFile(cfg.csproj,
      `<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <LangVersion>7.1</LangVersion>
    <OutputType>Library</OutputType>
     <TargetFramework>netstandard2.0</TargetFramework>
    <nowarn>1998</nowarn> <!-- some methods are marked async that don't have an await in them.-->
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="System.Management.Automation.dll" Version="10.0.10586" />
    <PackageReference Include="Microsoft.CSharp" Version="4.5" />
    <PackageReference Include="System.Text.Encodings.Web" Version="4.5.0" />
  </ItemGroup>
</Project>
`, undefined, 'source-file-csharp');
  }
}

async function generateModule(service: Host, project: Project) {
  // write out the psd1 file if it's not there.
  const cfg = await settings(service);
  // if (!await service.ReadFile(cfg.psd1)) {

  // todo: change this to *update* the psd1?

  service.WriteFile(cfg.psd1, `@{
    ModuleVersion="1.0"
    NestedModules = @(
    "./bin/Debug/netstandard2.0/${cfg.moduleName}.private.dll"
    "${cfg.psm1}"
    )
    # don't export any actual cmdlets by default
    CmdletsToExport = ''

    # export the functions that we loaded (these are the proxy cmdlets)
    FunctionsToExport = '*-*'
}
`, undefined, 'source-file-powershell');
  //}

  // write out the psm1 file if it's not there.
  //if (!await service.ReadFile(cfg.psm1)) {
  service.WriteFile(cfg.psm1, `

#region AzureCommonInitialization

# load the private module
ipmo "$PSScriptRoot/bin/Debug/netstandard2.0/${cfg.moduleName}.private.dll"

# export the 'exported' cmdlets 
Get-ChildItem "$PSScriptRoot/exported" -Recurse -Filter "*.ps1" -File | Sort-Object Name | Foreach { 
    Write-Verbose "Dot sourcing private script file: $($_.Name)"
    . $_.FullName
    # Explicity export the member
    Export-ModuleMember -Function $_.BaseName
}

$module = ipmo -passthru -ea 0 "$PSScriptRoot/../CommonModule"

if ($module) {
  Write-Host "Loaded Common Module '$($module.Name)'"

  # this module instance.
  $instance =  [${project.serviceNamespace.moduleClass.declaration}]::Instance

  # ask for the table of functions we can call in the common module.
  $VTable = Register-AzureModule

  # delegate responsibility to the common module for tweaking the pipeline at module load
  $instance.OnModuleLoad = $VTable.OnModuleLoad

  # and a chance to tweak the pipeline when we are about to make a call.
  $instance.OnNewRequest = $VTable.OnNewRequest

  # Need to get parameter values back from the common module
  $instance.GetParameterValue = $VTable.GetParameterValue

  # need to let the common module listen to events from this module
  $instance.EventListener = $VTable.EventListener

  # finish initialization of this module
  $instance.Init();
  }
#endregion
`, undefined, 'source-file-powershell');

  //}
}