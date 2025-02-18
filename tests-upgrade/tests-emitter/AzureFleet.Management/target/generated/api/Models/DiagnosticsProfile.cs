// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
    public partial class DiagnosticsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiagnosticsProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiagnosticsProfileInternal
    {

        /// <summary>Backing field for <see cref="BootDiagnostic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnostics _bootDiagnostic;

        /// <summary>
        /// Boot Diagnostics is a debugging feature which allows you to view Console Output
        /// and Screenshot to diagnose VM status. **NOTE**: If storageUri is being
        /// specified then ensure that the storage account is in the same region and
        /// subscription as the VM. You can easily view the output of your console log.
        /// Azure also enables you to see a screenshot of the VM from the hypervisor.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnostics BootDiagnostic { get => (this._bootDiagnostic = this._bootDiagnostic ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.BootDiagnostics()); set => this._bootDiagnostic = value; }

        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? BootDiagnosticEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnosticsInternal)BootDiagnostic).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnosticsInternal)BootDiagnostic).Enabled = value ?? default(bool); }

        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string BootDiagnosticStorageUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnosticsInternal)BootDiagnostic).StorageUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnosticsInternal)BootDiagnostic).StorageUri = value ?? null; }

        /// <summary>Internal Acessors for BootDiagnostic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnostics Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiagnosticsProfileInternal.BootDiagnostic { get => (this._bootDiagnostic = this._bootDiagnostic ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.BootDiagnostics()); set { {_bootDiagnostic = value;} } }

        /// <summary>Creates an new <see cref="DiagnosticsProfile" /> instance.</summary>
        public DiagnosticsProfile()
        {

        }
    }
    /// Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.
    public partial interface IDiagnosticsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether boot diagnostics should be enabled on the Virtual Machine.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BootDiagnosticEnabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Uri of the storage account to use for placing the console output and
        screenshot. If storageUri is not specified while enabling boot diagnostics,
        managed storage will be used.",
        SerializedName = @"storageUri",
        PossibleTypes = new [] { typeof(string) })]
        string BootDiagnosticStorageUri { get; set; }

    }
    /// Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.
    internal partial interface IDiagnosticsProfileInternal

    {
        /// <summary>
        /// Boot Diagnostics is a debugging feature which allows you to view Console Output
        /// and Screenshot to diagnose VM status. **NOTE**: If storageUri is being
        /// specified then ensure that the storage account is in the same region and
        /// subscription as the VM. You can easily view the output of your console log.
        /// Azure also enables you to see a screenshot of the VM from the hypervisor.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBootDiagnostics BootDiagnostic { get; set; }
        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        bool? BootDiagnosticEnabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        string BootDiagnosticStorageUri { get; set; }

    }
}