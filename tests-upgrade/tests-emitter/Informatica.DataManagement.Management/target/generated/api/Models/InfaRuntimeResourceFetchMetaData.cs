// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>
    /// Informatica runtime resource metadata as received via the informatica fetch all runtime environments API
    /// </summary>
    public partial class InfaRuntimeResourceFetchMetaData :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal
    {

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private string _createdBy;

        /// <summary>Created by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string CreatedBy { get => this._createdBy; set => this._createdBy = value; }

        /// <summary>Backing field for <see cref="CreatedTime" /> property.</summary>
        private string _createdTime;

        /// <summary>Created time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string CreatedTime { get => this._createdTime; set => this._createdTime = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the runtime resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Informatica serverless runtime id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for ServerlessConfigProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal.ServerlessConfigProperty { get => (this._serverlessConfigProperty = this._serverlessConfigProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties()); set { {_serverlessConfigProperty = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Environment name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ServerlessConfigProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties _serverlessConfigProperty;

        /// <summary>Serverless Config Properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties ServerlessConfigProperty { get => (this._serverlessConfigProperty = this._serverlessConfigProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigProperties()); set => this._serverlessConfigProperty = value; }

        /// <summary>Advanced custom properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyAdvancedCustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).AdvancedCustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).AdvancedCustomProperty = value ?? null; }

        /// <summary>applicationType name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyApplicationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ApplicationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ApplicationType = value ?? null; }

        /// <summary>Compute Units</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyComputeUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ComputeUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ComputeUnit = value ?? null; }

        /// <summary>Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyExecutionTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ExecutionTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ExecutionTimeout = value ?? null; }

        /// <summary>Serverless Account Platform</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyPlatform { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Platform; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Platform = value ?? null; }

        /// <summary>region name for the runtime environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Region; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Region = value ?? null; }

        /// <summary>Resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ResourceGroupName = value ?? null; }

        /// <summary>Serverless Arm Resource ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyServerlessArmResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ServerlessArmResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).ServerlessArmResourceId = value ?? null; }

        /// <summary>subnet name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertySubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Subnet = value ?? null; }

        /// <summary>subscription ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertySubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).SubscriptionId = value ?? null; }

        /// <summary>Supplementary File location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertySupplementaryFileLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).SupplementaryFileLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).SupplementaryFileLocation = value ?? null; }

        /// <summary>Tags for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Tag = value ?? null; }

        /// <summary>Tenant ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).TenantId = value ?? null; }

        /// <summary>virtual network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyVnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Vnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal)ServerlessConfigProperty).Vnet = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="StatusLocalized" /> property.</summary>
        private string _statusLocalized;

        /// <summary>Display message for the given status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string StatusLocalized { get => this._statusLocalized; set => this._statusLocalized = value; }

        /// <summary>Backing field for <see cref="StatusMessage" /> property.</summary>
        private string _statusMessage;

        /// <summary>status message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string StatusMessage { get => this._statusMessage; set => this._statusMessage = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"SERVERLESS";

        /// <summary>Environment Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Backing field for <see cref="UpdatedBy" /> property.</summary>
        private string _updatedBy;

        /// <summary>Last Updated by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string UpdatedBy { get => this._updatedBy; set => this._updatedBy = value; }

        /// <summary>Backing field for <see cref="UpdatedTime" /> property.</summary>
        private string _updatedTime;

        /// <summary>Updated Time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string UpdatedTime { get => this._updatedTime; set => this._updatedTime = value; }

        /// <summary>Creates an new <see cref="InfaRuntimeResourceFetchMetaData" /> instance.</summary>
        public InfaRuntimeResourceFetchMetaData()
        {

        }
    }
    /// Informatica runtime resource metadata as received via the informatica fetch all runtime environments API
    public partial interface IInfaRuntimeResourceFetchMetaData :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Created by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Created by",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get; set; }
        /// <summary>Created time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Created time",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedTime { get; set; }
        /// <summary>Description of the runtime resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the runtime resource",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Informatica serverless runtime id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Informatica serverless runtime id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Environment name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Environment name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Advanced custom properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Advanced custom properties",
        SerializedName = @"advancedCustomProperties",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyAdvancedCustomProperty { get; set; }
        /// <summary>applicationType name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"applicationType name",
        SerializedName = @"applicationType",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyApplicationType { get; set; }
        /// <summary>Compute Units</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Compute Units",
        SerializedName = @"computeUnits",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyComputeUnit { get; set; }
        /// <summary>Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Execution timeout",
        SerializedName = @"executionTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyExecutionTimeout { get; set; }
        /// <summary>Serverless Account Platform</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Account Platform",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyPlatform { get; set; }
        /// <summary>region name for the runtime environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"region name for the runtime environment",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyRegion { get; set; }
        /// <summary>Resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource group name",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyResourceGroupName { get; set; }
        /// <summary>Serverless Arm Resource ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Arm Resource ID",
        SerializedName = @"serverlessArmResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyServerlessArmResourceId { get; set; }
        /// <summary>subnet name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"subnet name",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertySubnet { get; set; }
        /// <summary>subscription ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"subscription ID",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertySubscriptionId { get; set; }
        /// <summary>Supplementary File location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supplementary File location",
        SerializedName = @"supplementaryFileLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertySupplementaryFileLocation { get; set; }
        /// <summary>Tags for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tags for the resource",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyTag { get; set; }
        /// <summary>Tenant ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant ID",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyTenantId { get; set; }
        /// <summary>virtual network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"virtual network",
        SerializedName = @"vnet",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyVnet { get; set; }
        /// <summary>Status of the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the environment",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>Display message for the given status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Display message for the given status",
        SerializedName = @"statusLocalized",
        PossibleTypes = new [] { typeof(string) })]
        string StatusLocalized { get; set; }
        /// <summary>status message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"status message",
        SerializedName = @"statusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMessage { get; set; }
        /// <summary>Environment Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Environment Type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("SERVERLESS")]
        string Type { get;  }
        /// <summary>Last Updated by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last Updated by",
        SerializedName = @"updatedBy",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedBy { get; set; }
        /// <summary>Updated Time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Updated Time",
        SerializedName = @"updatedTime",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedTime { get; set; }

    }
    /// Informatica runtime resource metadata as received via the informatica fetch all runtime environments API
    internal partial interface IInfaRuntimeResourceFetchMetaDataInternal

    {
        /// <summary>Created by</summary>
        string CreatedBy { get; set; }
        /// <summary>Created time</summary>
        string CreatedTime { get; set; }
        /// <summary>Description of the runtime resource</summary>
        string Description { get; set; }
        /// <summary>Informatica serverless runtime id</summary>
        string Id { get; set; }
        /// <summary>Environment name</summary>
        string Name { get; set; }
        /// <summary>Serverless Config Properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties ServerlessConfigProperty { get; set; }
        /// <summary>Advanced custom properties</summary>
        string ServerlessConfigPropertyAdvancedCustomProperty { get; set; }
        /// <summary>applicationType name</summary>
        string ServerlessConfigPropertyApplicationType { get; set; }
        /// <summary>Compute Units</summary>
        string ServerlessConfigPropertyComputeUnit { get; set; }
        /// <summary>Execution timeout</summary>
        string ServerlessConfigPropertyExecutionTimeout { get; set; }
        /// <summary>Serverless Account Platform</summary>
        string ServerlessConfigPropertyPlatform { get; set; }
        /// <summary>region name for the runtime environment</summary>
        string ServerlessConfigPropertyRegion { get; set; }
        /// <summary>Resource group name</summary>
        string ServerlessConfigPropertyResourceGroupName { get; set; }
        /// <summary>Serverless Arm Resource ID</summary>
        string ServerlessConfigPropertyServerlessArmResourceId { get; set; }
        /// <summary>subnet name</summary>
        string ServerlessConfigPropertySubnet { get; set; }
        /// <summary>subscription ID</summary>
        string ServerlessConfigPropertySubscriptionId { get; set; }
        /// <summary>Supplementary File location</summary>
        string ServerlessConfigPropertySupplementaryFileLocation { get; set; }
        /// <summary>Tags for the resource</summary>
        string ServerlessConfigPropertyTag { get; set; }
        /// <summary>Tenant ID</summary>
        string ServerlessConfigPropertyTenantId { get; set; }
        /// <summary>virtual network</summary>
        string ServerlessConfigPropertyVnet { get; set; }
        /// <summary>Status of the environment</summary>
        string Status { get; set; }
        /// <summary>Display message for the given status</summary>
        string StatusLocalized { get; set; }
        /// <summary>status message</summary>
        string StatusMessage { get; set; }
        /// <summary>Environment Type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("SERVERLESS")]
        string Type { get; set; }
        /// <summary>Last Updated by</summary>
        string UpdatedBy { get; set; }
        /// <summary>Updated Time</summary>
        string UpdatedTime { get; set; }

    }
}