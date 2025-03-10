// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Azure DevOps organization profile</summary>
    public partial class AzureDevOpsOrganizationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsOrganizationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsOrganizationProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile __organizationProfile = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OrganizationProfile();

        /// <summary>Discriminator property for OrganizationProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Kind { get => "AzureDevOps"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfileInternal)__organizationProfile).Kind = "AzureDevOps"; }

        /// <summary>Internal Acessors for PermissionProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsOrganizationProfileInternal.PermissionProfile { get => (this._permissionProfile = this._permissionProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AzureDevOpsPermissionProfile()); set { {_permissionProfile = value;} } }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganization> _organization;

        /// <summary>The list of Azure DevOps organizations the pool should be present in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganization> Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="PermissionProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfile _permissionProfile;

        /// <summary>
        /// The type of permission which determines which accounts are admins on the Azure DevOps pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfile PermissionProfile { get => (this._permissionProfile = this._permissionProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.AzureDevOpsPermissionProfile()); set => this._permissionProfile = value; }

        /// <summary>Group email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PermissionProfileGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal)PermissionProfile).Group; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal)PermissionProfile).Group = value ?? null /* arrayOf */; }

        /// <summary>Determines who has admin permissions to the Azure DevOps pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string PermissionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal)PermissionProfile).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal)PermissionProfile).Kind = value ?? null; }

        /// <summary>User email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PermissionProfileUser { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal)PermissionProfile).User; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal)PermissionProfile).User = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="AzureDevOpsOrganizationProfile" /> instance.</summary>
        public AzureDevOpsOrganizationProfile()
        {
            this.__organizationProfile.Kind = "AzureDevOps";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__organizationProfile), __organizationProfile);
            await eventListener.AssertObjectIsValid(nameof(__organizationProfile), __organizationProfile);
        }
    }
    /// Azure DevOps organization profile
    public partial interface IAzureDevOpsOrganizationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile
    {
        /// <summary>The list of Azure DevOps organizations the pool should be present in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of Azure DevOps organizations the pool should be present in.",
        SerializedName = @"organizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganization) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganization> Organization { get; set; }
        /// <summary>Group email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Group email addresses",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> PermissionProfileGroup { get; set; }
        /// <summary>Determines who has admin permissions to the Azure DevOps pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines who has admin permissions to the Azure DevOps pool.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Inherit", "CreatorOnly", "SpecificAccounts")]
        string PermissionProfileKind { get; set; }
        /// <summary>User email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User email addresses",
        SerializedName = @"users",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> PermissionProfileUser { get; set; }

    }
    /// Azure DevOps organization profile
    internal partial interface IAzureDevOpsOrganizationProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfileInternal
    {
        /// <summary>The list of Azure DevOps organizations the pool should be present in.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganization> Organization { get; set; }
        /// <summary>
        /// The type of permission which determines which accounts are admins on the Azure DevOps pool.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfile PermissionProfile { get; set; }
        /// <summary>Group email addresses</summary>
        System.Collections.Generic.List<string> PermissionProfileGroup { get; set; }
        /// <summary>Determines who has admin permissions to the Azure DevOps pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Inherit", "CreatorOnly", "SpecificAccounts")]
        string PermissionProfileKind { get; set; }
        /// <summary>User email addresses</summary>
        System.Collections.Generic.List<string> PermissionProfileUser { get; set; }

    }
}