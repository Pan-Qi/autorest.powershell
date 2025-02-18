// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The information of 'bring your own storage' account binding to the report</summary>
    public partial class StorageInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfo,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IStorageInfoInternal
    {

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>'bring your own storage' account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The region of 'bring your own storage' account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="ResourceGroup" /> property.</summary>
        private string _resourceGroup;

        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceGroup { get => this._resourceGroup; set => this._resourceGroup = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="StorageInfo" /> instance.</summary>
        public StorageInfo()
        {

        }
    }
    /// The information of 'bring your own storage' account binding to the report
    public partial interface IStorageInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>'bring your own storage' account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"'bring your own storage' account name",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }
        /// <summary>The region of 'bring your own storage' account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The region of 'bring your own storage' account",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resourceGroup which 'bring your own storage' account belongs to",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroup { get; set; }
        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subscription id which 'bring your own storage' account belongs to",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    /// The information of 'bring your own storage' account binding to the report
    internal partial interface IStorageInfoInternal

    {
        /// <summary>'bring your own storage' account name</summary>
        string AccountName { get; set; }
        /// <summary>The region of 'bring your own storage' account</summary>
        string Location { get; set; }
        /// <summary>The resourceGroup which 'bring your own storage' account belongs to</summary>
        string ResourceGroup { get; set; }
        /// <summary>The subscription id which 'bring your own storage' account belongs to</summary>
        string SubscriptionId { get; set; }

    }
}