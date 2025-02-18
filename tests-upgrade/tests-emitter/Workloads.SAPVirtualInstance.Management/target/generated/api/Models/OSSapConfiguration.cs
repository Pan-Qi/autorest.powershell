// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the OS and SAP Configurations for Deployment</summary>
    public partial class OSSapConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal
    {

        /// <summary>Backing field for <see cref="DeployerVMPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages _deployerVMPackage;

        /// <summary>The url and storage account ID where deployer VM packages are uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages DeployerVMPackage { get => (this._deployerVMPackage = this._deployerVMPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DeployerVMPackages()); set => this._deployerVMPackage = value; }

        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DeployerVMPackageStorageAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackagesInternal)DeployerVMPackage).StorageAccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackagesInternal)DeployerVMPackage).StorageAccountId = value ?? null; }

        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DeployerVMPackageUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackagesInternal)DeployerVMPackage).Url; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackagesInternal)DeployerVMPackage).Url = value ?? null; }

        /// <summary>Internal Acessors for DeployerVMPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IOSSapConfigurationInternal.DeployerVMPackage { get => (this._deployerVMPackage = this._deployerVMPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DeployerVMPackages()); set { {_deployerVMPackage = value;} } }

        /// <summary>Backing field for <see cref="SapFqdn" /> property.</summary>
        private string _sapFqdn;

        /// <summary>The FQDN to set for the SAP system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SapFqdn { get => this._sapFqdn; set => this._sapFqdn = value; }

        /// <summary>Creates an new <see cref="OSSapConfiguration" /> instance.</summary>
        public OSSapConfiguration()
        {

        }
    }
    /// Defines the OS and SAP Configurations for Deployment
    public partial interface IOSSapConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deployer VM packages storage account id",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string DeployerVMPackageStorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to the deployer VM packages file.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string DeployerVMPackageUrl { get; set; }
        /// <summary>The FQDN to set for the SAP system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The FQDN to set for the SAP system",
        SerializedName = @"sapFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string SapFqdn { get; set; }

    }
    /// Defines the OS and SAP Configurations for Deployment
    internal partial interface IOSSapConfigurationInternal

    {
        /// <summary>The url and storage account ID where deployer VM packages are uploaded</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDeployerVMPackages DeployerVMPackage { get; set; }
        /// <summary>The deployer VM packages storage account id</summary>
        string DeployerVMPackageStorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        string DeployerVMPackageUrl { get; set; }
        /// <summary>The FQDN to set for the SAP system</summary>
        string SapFqdn { get; set; }

    }
}