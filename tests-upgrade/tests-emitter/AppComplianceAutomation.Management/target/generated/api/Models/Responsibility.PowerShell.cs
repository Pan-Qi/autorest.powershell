// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>A class represent the customer responsibility.</summary>
    [System.ComponentModel.TypeConverter(typeof(ResponsibilityTypeConverter))]
    public partial class Responsibility
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Responsibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Responsibility(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Responsibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Responsibility(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Responsibility" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Responsibility" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibility FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Responsibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Responsibility(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Environment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("FailedResourceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).FailedResourceCount = (int?) content.GetValueForProperty("FailedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).FailedResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TotalResourceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).TotalResourceCount = (int?) content.GetValueForProperty("TotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).TotalResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ResourceList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).ResourceList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource>) content.GetValueForProperty("ResourceList",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).ResourceList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResponsibilityResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecommendationList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).RecommendationList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation>) content.GetValueForProperty("RecommendationList",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).RecommendationList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.RecommendationTypeConverter.ConvertFrom));
            }
            if (content.Contains("Guidance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Guidance = (string) content.GetValueForProperty("Guidance",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Guidance, global::System.Convert.ToString);
            }
            if (content.Contains("Justification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Justification = (string) content.GetValueForProperty("Justification",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Justification, global::System.Convert.ToString);
            }
            if (content.Contains("EvidenceFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).EvidenceFile = (System.Collections.Generic.List<string>) content.GetValueForProperty("EvidenceFile",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).EvidenceFile, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Responsibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Responsibility(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Environment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("FailedResourceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).FailedResourceCount = (int?) content.GetValueForProperty("FailedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).FailedResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TotalResourceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).TotalResourceCount = (int?) content.GetValueForProperty("TotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).TotalResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ResourceList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).ResourceList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource>) content.GetValueForProperty("ResourceList",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).ResourceList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResponsibilityResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecommendationList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).RecommendationList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation>) content.GetValueForProperty("RecommendationList",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).RecommendationList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IRecommendation>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.RecommendationTypeConverter.ConvertFrom));
            }
            if (content.Contains("Guidance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Guidance = (string) content.GetValueForProperty("Guidance",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Guidance, global::System.Convert.ToString);
            }
            if (content.Contains("Justification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Justification = (string) content.GetValueForProperty("Justification",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).Justification, global::System.Convert.ToString);
            }
            if (content.Contains("EvidenceFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).EvidenceFile = (System.Collections.Generic.List<string>) content.GetValueForProperty("EvidenceFile",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityInternal)this).EvidenceFile, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A class represent the customer responsibility.
    [System.ComponentModel.TypeConverter(typeof(ResponsibilityTypeConverter))]
    public partial interface IResponsibility

    {

    }
}