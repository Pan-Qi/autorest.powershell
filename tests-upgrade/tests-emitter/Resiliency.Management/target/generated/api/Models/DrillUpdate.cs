// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Extensions;

    /// <summary>The type used for update operations of the Drill.</summary>
    public partial class DrillUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal
    {

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string ChaosResourceIdentityForFaultType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourceIdentityForFaultType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourceIdentityForFaultType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string ChaosResourceIdentityForFaultUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourceIdentityForFaultUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourceIdentityForFaultUserAssignedIdentity = value ?? null; }

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string ChaosResourcePropertiesIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertiesIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertiesIdentityType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string ChaosResourcePropertiesIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertiesIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertiesIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Chaos Resource created for this Drill</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string ChaosResourcePropertyChaosResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyChaosResourceId; }

        /// <summary>Duration of faults.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public int? ChaosResourcePropertyFaultDurationInMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyFaultDurationInMin; }

        /// <summary>Region where Drill's internal resources will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string DrillAssetPropertyRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetPropertyRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetPropertyRegion = value ?? null; }

        /// <summary>
        /// Resource group where Drill's internal resources will be created. If not specified, defaults to 'AzureResilienceManagementDrills'.
        /// This value is immutable after drill creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string DrillAssetPropertyResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetPropertyResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetPropertyResourceGroup = value ?? null; }

        /// <summary>Subscription where Drill's internal resources will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string DrillAssetPropertySubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetPropertySubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetPropertySubscription = value ?? null; }

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string GoalAssignmentPropertiesIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertiesIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertiesIdentityType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string GoalAssignmentPropertiesIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertiesIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertiesIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Goal assignment id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string GoalAssignmentPropertyGoalAssignmentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertyGoalAssignmentId; }

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string HealthModelMonitoringPropertiesIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertiesIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertiesIdentityType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string HealthModelMonitoringPropertiesIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertiesIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertiesIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Full ARM Id of the Azure Health Model selected for Drill monitoring.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string HealthModelMonitoringPropertyHealthModelId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertyHealthModelId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertyHealthModelId = value ?? null; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ChaosResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IChaosResourcePropertiesOfDrill Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.ChaosResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ChaosResourcePropertyChaosResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.ChaosResourcePropertyChaosResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyChaosResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyChaosResourceId = value ?? null; }

        /// <summary>Internal Acessors for ChaosResourcePropertyChaosResourceIdentityForFault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.ChaosResourcePropertyChaosResourceIdentityForFault { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyChaosResourceIdentityForFault; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyChaosResourceIdentityForFault = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ChaosResourcePropertyFaultDurationInMin</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.ChaosResourcePropertyFaultDurationInMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyFaultDurationInMin; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyFaultDurationInMin = value ?? default(int); }

        /// <summary>Internal Acessors for ChaosResourcePropertyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.ChaosResourcePropertyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).ChaosResourcePropertyIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DrillAssetProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssetPropertiesOfDrill Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.DrillAssetProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).DrillAssetProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GoalAssignmentProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IGoalAssignmentPropertiesOfDrill Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.GoalAssignmentProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for GoalAssignmentPropertyGoalAssignmentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.GoalAssignmentPropertyGoalAssignmentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertyGoalAssignmentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertyGoalAssignmentId = value ?? null; }

        /// <summary>Internal Acessors for GoalAssignmentPropertyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.GoalAssignmentPropertyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).GoalAssignmentPropertyIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HealthModelMonitoringProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IHealthModelMonitoringProperties Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.HealthModelMonitoringProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HealthModelMonitoringPropertyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.HealthModelMonitoringPropertyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).HealthModelMonitoringPropertyIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for MonitoringProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IMonitoringPropertiesOfDrill Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.MonitoringProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringPropertyDataCollectionEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.MonitoringPropertyDataCollectionEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyDataCollectionEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyDataCollectionEndpointId = value ?? null; }

        /// <summary>Internal Acessors for MonitoringPropertyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.MonitoringPropertyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonitoringPropertyLogAnalyticsWorkspaceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.MonitoringPropertyLogAnalyticsWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyLogAnalyticsWorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyLogAnalyticsWorkspaceId = value ?? null; }

        /// <summary>Internal Acessors for MonitoringPropertyRawMetricsDataCollectionRuleId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.MonitoringPropertyRawMetricsDataCollectionRuleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyRawMetricsDataCollectionRuleId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyRawMetricsDataCollectionRuleId = value ?? null; }

        /// <summary>Internal Acessors for MonitoringPropertyServiceGroupMetricsDataCollectionRuleId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.MonitoringPropertyServiceGroupMetricsDataCollectionRuleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyServiceGroupMetricsDataCollectionRuleId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyServiceGroupMetricsDataCollectionRuleId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.DrillUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RecoveryPlanProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IRecoveryPlanPropertiesOfDrill Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.RecoveryPlanProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RecoveryPlanPropertyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.RecoveryPlanPropertyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RecoveryPlanPropertyRecoveryPlanId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.RecoveryPlanPropertyRecoveryPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyRecoveryPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyRecoveryPlanId = value ?? null; }

        /// <summary>Internal Acessors for RecoveryPlanPropertyRecoveryPlanResourceExcludedCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.RecoveryPlanPropertyRecoveryPlanResourceExcludedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyRecoveryPlanResourceExcludedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyRecoveryPlanResourceExcludedCount = value ?? default(int); }

        /// <summary>Internal Acessors for SliMonitoringProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ISliMonitoringProperties Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.SliMonitoringProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SliMonitoringPropertyIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateInternal.SliMonitoringPropertyIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertyIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertyIdentity = value ?? null /* model class */; }

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string MonitoringPropertiesIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertiesIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertiesIdentityType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string MonitoringPropertiesIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertiesIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertiesIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>
        /// Full ARM Id of the Data collection endpoint created by Resiliency service which will route data for service group and
        /// its resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string MonitoringPropertyDataCollectionEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyDataCollectionEndpointId; }

        /// <summary>
        /// Full ARM Id of the Log analytics workspace created by Resiliency service where health data is collected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string MonitoringPropertyLogAnalyticsWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyLogAnalyticsWorkspaceId; }

        /// <summary>
        /// Full ARM Id of the Data collection rule created by Resiliency service which will route data for RAW health data for service
        /// group resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string MonitoringPropertyRawMetricsDataCollectionRuleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyRawMetricsDataCollectionRuleId; }

        /// <summary>
        /// Full ARM Id of the Data collection rule created by Resiliency service which will route data for Aggregate health data
        /// of service group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string MonitoringPropertyServiceGroupMetricsDataCollectionRuleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).MonitoringPropertyServiceGroupMetricsDataCollectionRuleId; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.DrillUpdateProperties()); set => this._property = value; }

        /// <summary>RBAC setup mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string RbacSetupMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RbacSetupMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RbacSetupMode = value ?? null; }

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string RecoveryPlanPropertiesIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertiesIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertiesIdentityType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string RecoveryPlanPropertiesIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertiesIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertiesIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Recovery Orchestration plan associated with this Drill.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string RecoveryPlanPropertyRecoveryPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyRecoveryPlanId; }

        /// <summary>Excluded resource count in RecoveryPlan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public int? RecoveryPlanPropertyRecoveryPlanResourceExcludedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).RecoveryPlanPropertyRecoveryPlanResourceExcludedCount; }

        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string SliMonitoringPropertiesIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertiesIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertiesIdentityType = value ?? null; }

        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public string SliMonitoringPropertiesIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertiesIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertiesIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>
        /// The SLIs selected for Drill monitoring. Maximum of two entries: at most one Availability and one Latency. Duplicate types
        /// or duplicate SLI Ids are rejected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ISliSelection> SliMonitoringPropertySli { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertySli; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdatePropertiesInternal)Property).SliMonitoringPropertySli = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="DrillUpdate" /> instance.</summary>
        public DrillUpdate()
        {

        }
    }
    /// The type used for update operations of the Drill.
    public partial interface IDrillUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.IJsonSerializable
    {
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string ChaosResourceIdentityForFaultType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string ChaosResourceIdentityForFaultUserAssignedIdentity { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string ChaosResourcePropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string ChaosResourcePropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Chaos Resource created for this Drill</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Chaos Resource created for this Drill",
        SerializedName = @"chaosResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ChaosResourcePropertyChaosResourceId { get;  }
        /// <summary>Duration of faults.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Duration of faults.",
        SerializedName = @"faultDurationInMin",
        PossibleTypes = new [] { typeof(int) })]
        int? ChaosResourcePropertyFaultDurationInMin { get;  }
        /// <summary>Region where Drill's internal resources will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Region where Drill's internal resources will be created.",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string DrillAssetPropertyRegion { get; set; }
        /// <summary>
        /// Resource group where Drill's internal resources will be created. If not specified, defaults to 'AzureResilienceManagementDrills'.
        /// This value is immutable after drill creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Resource group where Drill's internal resources will be created. If not specified, defaults to 'AzureResilienceManagementDrills'. This value is immutable after drill creation.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string DrillAssetPropertyResourceGroup { get; set; }
        /// <summary>Subscription where Drill's internal resources will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subscription where Drill's internal resources will be created.",
        SerializedName = @"subscription",
        PossibleTypes = new [] { typeof(string) })]
        string DrillAssetPropertySubscription { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string GoalAssignmentPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string GoalAssignmentPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Goal assignment id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Goal assignment id.",
        SerializedName = @"goalAssignmentId",
        PossibleTypes = new [] { typeof(string) })]
        string GoalAssignmentPropertyGoalAssignmentId { get;  }
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string HealthModelMonitoringPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string HealthModelMonitoringPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Full ARM Id of the Azure Health Model selected for Drill monitoring.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full ARM Id of the Azure Health Model selected for Drill monitoring.",
        SerializedName = @"healthModelId",
        PossibleTypes = new [] { typeof(string) })]
        string HealthModelMonitoringPropertyHealthModelId { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string MonitoringPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// Full ARM Id of the Data collection endpoint created by Resiliency service which will route data for service group and
        /// its resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Full ARM Id of the Data collection endpoint created by Resiliency service which will route data for service group and its resources.",
        SerializedName = @"dataCollectionEndpointId",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPropertyDataCollectionEndpointId { get;  }
        /// <summary>
        /// Full ARM Id of the Log analytics workspace created by Resiliency service where health data is collected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Full ARM Id of the Log analytics workspace created by Resiliency service where health data is collected.",
        SerializedName = @"logAnalyticsWorkspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPropertyLogAnalyticsWorkspaceId { get;  }
        /// <summary>
        /// Full ARM Id of the Data collection rule created by Resiliency service which will route data for RAW health data for service
        /// group resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Full ARM Id of the Data collection rule created by Resiliency service which will route data for RAW health data for service group resources.",
        SerializedName = @"rawMetricsDataCollectionRuleId",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPropertyRawMetricsDataCollectionRuleId { get;  }
        /// <summary>
        /// Full ARM Id of the Data collection rule created by Resiliency service which will route data for Aggregate health data
        /// of service group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Full ARM Id of the Data collection rule created by Resiliency service which will route data for Aggregate health data of service group.",
        SerializedName = @"serviceGroupMetricsDataCollectionRuleId",
        PossibleTypes = new [] { typeof(string) })]
        string MonitoringPropertyServiceGroupMetricsDataCollectionRuleId { get;  }
        /// <summary>RBAC setup mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"RBAC setup mode.",
        SerializedName = @"rbacSetupMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("AutomatedCustomRole", "AutomatedBuiltinRoles", "Manual")]
        string RbacSetupMode { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string RecoveryPlanPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPlanPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Recovery Orchestration plan associated with this Drill.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Recovery Orchestration plan associated with this Drill.",
        SerializedName = @"recoveryPlanId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPlanPropertyRecoveryPlanId { get;  }
        /// <summary>Excluded resource count in RecoveryPlan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Excluded resource count in RecoveryPlan.",
        SerializedName = @"recoveryPlanResourceExcludedCount",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryPlanPropertyRecoveryPlanResourceExcludedCount { get;  }
        /// <summary>Identity type linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type linked with the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string SliMonitoringPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity id linked with the resource",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string SliMonitoringPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The SLIs selected for Drill monitoring. Maximum of two entries: at most one Availability and one Latency. Duplicate types
        /// or duplicate SLI Ids are rejected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SLIs selected for Drill monitoring. Maximum of two entries: at most one Availability and one Latency. Duplicate types or duplicate SLI Ids are rejected.",
        SerializedName = @"slis",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ISliSelection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ISliSelection> SliMonitoringPropertySli { get; set; }

    }
    /// The type used for update operations of the Drill.
    internal partial interface IDrillUpdateInternal

    {
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string ChaosResourceIdentityForFaultType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string ChaosResourceIdentityForFaultUserAssignedIdentity { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string ChaosResourcePropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string ChaosResourcePropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Chaos Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IChaosResourcePropertiesOfDrill ChaosResourceProperty { get; set; }
        /// <summary>Chaos Resource created for this Drill</summary>
        string ChaosResourcePropertyChaosResourceId { get; set; }
        /// <summary>Identity to be used by the Chaos Resource for invoking faults on resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity ChaosResourcePropertyChaosResourceIdentityForFault { get; set; }
        /// <summary>Duration of faults.</summary>
        int? ChaosResourcePropertyFaultDurationInMin { get; set; }
        /// <summary>Identity to use for Chaos Resource operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity ChaosResourcePropertyIdentity { get; set; }
        /// <summary>Properties for internal resources that are created for the Drill.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssetPropertiesOfDrill DrillAssetProperty { get; set; }
        /// <summary>Region where Drill's internal resources will be created.</summary>
        string DrillAssetPropertyRegion { get; set; }
        /// <summary>
        /// Resource group where Drill's internal resources will be created. If not specified, defaults to 'AzureResilienceManagementDrills'.
        /// This value is immutable after drill creation.
        /// </summary>
        string DrillAssetPropertyResourceGroup { get; set; }
        /// <summary>Subscription where Drill's internal resources will be created.</summary>
        string DrillAssetPropertySubscription { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string GoalAssignmentPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string GoalAssignmentPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Goal Assignment properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IGoalAssignmentPropertiesOfDrill GoalAssignmentProperty { get; set; }
        /// <summary>Goal assignment id.</summary>
        string GoalAssignmentPropertyGoalAssignmentId { get; set; }
        /// <summary>Identity to use for goal assignment operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity GoalAssignmentPropertyIdentity { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string HealthModelMonitoringPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string HealthModelMonitoringPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// Azure Health Model monitoring properties of the Drill. Send null to clear the selection.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IHealthModelMonitoringProperties HealthModelMonitoringProperty { get; set; }
        /// <summary>Full ARM Id of the Azure Health Model selected for Drill monitoring.</summary>
        string HealthModelMonitoringPropertyHealthModelId { get; set; }
        /// <summary>
        /// Identity that the Drill uses to read the Azure Health Model. The Drill is granted Reader on the Health Model for this
        /// identity.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity HealthModelMonitoringPropertyIdentity { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string MonitoringPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string MonitoringPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Monitoring properties of the Drill.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IMonitoringPropertiesOfDrill MonitoringProperty { get; set; }
        /// <summary>
        /// Full ARM Id of the Data collection endpoint created by Resiliency service which will route data for service group and
        /// its resources.
        /// </summary>
        string MonitoringPropertyDataCollectionEndpointId { get; set; }
        /// <summary>Identity to use for Drill monitoring operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity MonitoringPropertyIdentity { get; set; }
        /// <summary>
        /// Full ARM Id of the Log analytics workspace created by Resiliency service where health data is collected.
        /// </summary>
        string MonitoringPropertyLogAnalyticsWorkspaceId { get; set; }
        /// <summary>
        /// Full ARM Id of the Data collection rule created by Resiliency service which will route data for RAW health data for service
        /// group resources.
        /// </summary>
        string MonitoringPropertyRawMetricsDataCollectionRuleId { get; set; }
        /// <summary>
        /// Full ARM Id of the Data collection rule created by Resiliency service which will route data for Aggregate health data
        /// of service group.
        /// </summary>
        string MonitoringPropertyServiceGroupMetricsDataCollectionRuleId { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IDrillUpdateProperties Property { get; set; }
        /// <summary>RBAC setup mode.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("AutomatedCustomRole", "AutomatedBuiltinRoles", "Manual")]
        string RbacSetupMode { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string RecoveryPlanPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string RecoveryPlanPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>Recovery Plan properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IRecoveryPlanPropertiesOfDrill RecoveryPlanProperty { get; set; }
        /// <summary>Identity to use for RecoveryPlan operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity RecoveryPlanPropertyIdentity { get; set; }
        /// <summary>Recovery Orchestration plan associated with this Drill.</summary>
        string RecoveryPlanPropertyRecoveryPlanId { get; set; }
        /// <summary>Excluded resource count in RecoveryPlan.</summary>
        int? RecoveryPlanPropertyRecoveryPlanResourceExcludedCount { get; set; }
        /// <summary>Identity type linked with the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Resiliency.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string SliMonitoringPropertiesIdentityType { get; set; }
        /// <summary>User assigned identity id linked with the resource</summary>
        string SliMonitoringPropertiesIdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// SLI monitoring properties of the Drill. Send null to clear the selection; the submitted slis array is the new desired
        /// state.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ISliMonitoringProperties SliMonitoringProperty { get; set; }
        /// <summary>
        /// Identity that the Drill uses to read evaluated SLI results from each SLI's destination Azure Monitor Workspace. The Drill
        /// is granted Monitoring Reader on every destination AMW of every selected SLI for this identity.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.IAssociatedIdentity SliMonitoringPropertyIdentity { get; set; }
        /// <summary>
        /// The SLIs selected for Drill monitoring. Maximum of two entries: at most one Availability and one Latency. Duplicate types
        /// or duplicate SLI Ids are rejected.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Resiliency.Models.ISliSelection> SliMonitoringPropertySli { get; set; }

    }
}