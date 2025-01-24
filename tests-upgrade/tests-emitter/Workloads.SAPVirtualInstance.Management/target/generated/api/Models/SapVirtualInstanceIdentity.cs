// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    public partial class SapVirtualInstanceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapVirtualInstanceIdentityInternal
    {

        /// <summary>Backing field for <see cref="ApplicationInstanceName" /> property.</summary>
        private string _applicationInstanceName;

        /// <summary>The name of SAP Application Server instance resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ApplicationInstanceName { get => this._applicationInstanceName; set => this._applicationInstanceName = value; }

        /// <summary>Backing field for <see cref="CentralInstanceName" /> property.</summary>
        private string _centralInstanceName;

        /// <summary>
        /// Central Services Instance resource name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string CentralInstanceName { get => this._centralInstanceName; set => this._centralInstanceName = value; }

        /// <summary>Backing field for <see cref="DatabaseInstanceName" /> property.</summary>
        private string _databaseInstanceName;

        /// <summary>
        /// Database resource name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DatabaseInstanceName { get => this._databaseInstanceName; set => this._databaseInstanceName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The name of the Azure region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SapVirtualInstanceName" /> property.</summary>
        private string _sapVirtualInstanceName;

        /// <summary>The name of the Virtual Instances for SAP solutions resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SapVirtualInstanceName { get => this._sapVirtualInstanceName; set => this._sapVirtualInstanceName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="SapVirtualInstanceIdentity" /> instance.</summary>
        public SapVirtualInstanceIdentity()
        {

        }
    }
    public partial interface ISapVirtualInstanceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The name of SAP Application Server instance resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of SAP Application Server instance resource.",
        SerializedName = @"applicationInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationInstanceName { get; set; }
        /// <summary>
        /// Central Services Instance resource name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Central Services Instance resource name string modeled as parameter for auto generation to work correctly.",
        SerializedName = @"centralInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        string CentralInstanceName { get; set; }
        /// <summary>
        /// Database resource name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Database resource name string modeled as parameter for auto generation to work correctly.",
        SerializedName = @"databaseInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseInstanceName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the Azure region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Azure region.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The name of the Virtual Instances for SAP solutions resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Virtual Instances for SAP solutions resource",
        SerializedName = @"sapVirtualInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        string SapVirtualInstanceName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface ISapVirtualInstanceIdentityInternal

    {
        /// <summary>The name of SAP Application Server instance resource.</summary>
        string ApplicationInstanceName { get; set; }
        /// <summary>
        /// Central Services Instance resource name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        string CentralInstanceName { get; set; }
        /// <summary>
        /// Database resource name string modeled as parameter for auto generation to work correctly.
        /// </summary>
        string DatabaseInstanceName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the Azure region.</summary>
        string Location { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The name of the Virtual Instances for SAP solutions resource</summary>
        string SapVirtualInstanceName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}