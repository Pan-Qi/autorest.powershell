// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    /// </summary>
    public partial class StandbyContainerGroupPoolRuntimeViewResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="InstanceCountSummary" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> _instanceCountSummary;

        /// <summary>
        /// A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> InstanceCountSummary { get => this._instanceCountSummary; }

        /// <summary>Internal Acessors for InstanceCountSummary</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal.InstanceCountSummary { get => this._instanceCountSummary; set { {_instanceCountSummary = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Creates an new <see cref="StandbyContainerGroupPoolRuntimeViewResourceProperties" /> instance.
        /// </summary>
        public StandbyContainerGroupPoolRuntimeViewResourceProperties()
        {

        }
    }
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    public partial interface IStandbyContainerGroupPoolRuntimeViewResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.",
        SerializedName = @"instanceCountSummary",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> InstanceCountSummary { get;  }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the provisioning state of the standby pool",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get;  }

    }
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    internal partial interface IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal

    {
        /// <summary>
        /// A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> InstanceCountSummary { get; set; }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }

    }
}