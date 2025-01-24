// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>The supported disk size details for a disk type.</summary>
    [System.ComponentModel.TypeConverter(typeof(DiskDetailsTypeConverter))]
    public partial class DiskDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiskDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiskDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiskDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskSkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("SizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SizeGb = (long?) content.GetValueForProperty("SizeGb",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MinimumSupportedDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MinimumSupportedDiskCount = (long?) content.GetValueForProperty("MinimumSupportedDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MinimumSupportedDiskCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MaximumSupportedDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MaximumSupportedDiskCount = (long?) content.GetValueForProperty("MaximumSupportedDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MaximumSupportedDiskCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("IopsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).IopsReadWrite = (long?) content.GetValueForProperty("IopsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).IopsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MbpsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MbpsReadWrite = (long?) content.GetValueForProperty("MbpsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MbpsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DiskTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).DiskTier = (string) content.GetValueForProperty("DiskTier",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).DiskTier, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SkuName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiskDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskSkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("SizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SizeGb = (long?) content.GetValueForProperty("SizeGb",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SizeGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MinimumSupportedDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MinimumSupportedDiskCount = (long?) content.GetValueForProperty("MinimumSupportedDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MinimumSupportedDiskCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MaximumSupportedDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MaximumSupportedDiskCount = (long?) content.GetValueForProperty("MaximumSupportedDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MaximumSupportedDiskCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("IopsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).IopsReadWrite = (long?) content.GetValueForProperty("IopsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).IopsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MbpsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MbpsReadWrite = (long?) content.GetValueForProperty("MbpsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).MbpsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DiskTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).DiskTier = (string) content.GetValueForProperty("DiskTier",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).DiskTier, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetailsInternal)this).SkuName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiskDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DiskDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The supported disk size details for a disk type.
    [System.ComponentModel.TypeConverter(typeof(DiskDetailsTypeConverter))]
    public partial interface IDiskDetails

    {

    }
}