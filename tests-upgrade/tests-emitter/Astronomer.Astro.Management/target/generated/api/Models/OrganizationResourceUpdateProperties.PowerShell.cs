// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.PowerShell;

    /// <summary>The updatable properties of the OrganizationResource.</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceUpdatePropertiesTypeConverter))]
    public partial class OrganizationResourceUpdateProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationResourceUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationResourceUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationResourceUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="OrganizationResourceUpdateProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationResourceUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties) content.GetValueForProperty("PartnerOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.PartnerOrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailRenewalMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailRenewalMode = (string) content.GetValueForProperty("OfferDetailRenewalMode",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailRenewalMode, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertySingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertySingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties) content.GetValueForProperty("PartnerOrganizationPropertySingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertySingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.SingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationId = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyWorkspaceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceId = (string) content.GetValueForProperty("PartnerOrganizationPropertyWorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationName = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyWorkspaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceName = (string) content.GetValueForProperty("PartnerOrganizationPropertyWorkspaceName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceName, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailEndDate = (global::System.DateTime?) content.GetValueForProperty("OfferDetailEndDate",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailEndDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyProvisioningState = (string) content.GetValueForProperty("SingleSignOnPropertyProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.OrganizationResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationResourceUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IPartnerOrganizationProperties) content.GetValueForProperty("PartnerOrganizationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationProperty, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.PartnerOrganizationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailRenewalMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailRenewalMode = (string) content.GetValueForProperty("OfferDetailRenewalMode",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailRenewalMode, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertySingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertySingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.ISingleSignOnProperties) content.GetValueForProperty("PartnerOrganizationPropertySingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertySingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.SingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationId = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyWorkspaceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceId = (string) content.GetValueForProperty("PartnerOrganizationPropertyWorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationName = (string) content.GetValueForProperty("PartnerOrganizationPropertyOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerOrganizationPropertyWorkspaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceName = (string) content.GetValueForProperty("PartnerOrganizationPropertyWorkspaceName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).PartnerOrganizationPropertyWorkspaceName, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailEndDate = (global::System.DateTime?) content.GetValueForProperty("OfferDetailEndDate",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).OfferDetailEndDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyProvisioningState = (string) content.GetValueForProperty("SingleSignOnPropertyProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOrganizationResourceUpdatePropertiesInternal)this).SingleSignOnPropertyProvisioningState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The updatable properties of the OrganizationResource.
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceUpdatePropertiesTypeConverter))]
    public partial interface IOrganizationResourceUpdateProperties

    {

    }
}