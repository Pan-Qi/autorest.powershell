// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>The properties of storage class of the StorageClass</summary>
    public partial class StorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="StorageClassTypeProperties" /> instance.</summary>
        public StorageClassTypeProperties()
        {

        }
    }
    /// The properties of storage class of the StorageClass
    public partial interface IStorageClassTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable
    {
        /// <summary>Type of the storage class.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the storage class.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Native", "RWX", "Blob", "NFS", "SMB")]
        string Type { get; set; }

    }
    /// The properties of storage class of the StorageClass
    internal partial interface IStorageClassTypePropertiesInternal

    {
        /// <summary>Type of the storage class.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Native", "RWX", "Blob", "NFS", "SMB")]
        string Type { get; set; }

    }
}