namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.PowerShell;

    /// <summary>An device resource belonging to a device group resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(DeviceTypeConverter))]
    public partial class Device
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.Device"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevice" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevice DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Device(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.Device"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevice" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevice DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Device(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.Device"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Device(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DevicePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).DeviceId = (string) content.GetValueForProperty("DeviceId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).DeviceId, global::System.Convert.ToString);
            }
            if (content.Contains("ChipSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ChipSku = (string) content.GetValueForProperty("ChipSku",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ChipSku, global::System.Convert.ToString);
            }
            if (content.Contains("LastAvailableOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastAvailableOSVersion = (string) content.GetValueForProperty("LastAvailableOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastAvailableOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastInstalledOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastInstalledOSVersion = (string) content.GetValueForProperty("LastInstalledOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastInstalledOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastOSUpdateUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastOSUpdateUtc = (global::System.DateTime?) content.GetValueForProperty("LastOSUpdateUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastOSUpdateUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdateRequestUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastUpdateRequestUtc = (global::System.DateTime?) content.GetValueForProperty("LastUpdateRequestUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastUpdateRequestUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.Device"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Device(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.DevicePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).DeviceId = (string) content.GetValueForProperty("DeviceId",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).DeviceId, global::System.Convert.ToString);
            }
            if (content.Contains("ChipSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ChipSku = (string) content.GetValueForProperty("ChipSku",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).ChipSku, global::System.Convert.ToString);
            }
            if (content.Contains("LastAvailableOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastAvailableOSVersion = (string) content.GetValueForProperty("LastAvailableOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastAvailableOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastInstalledOSVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastInstalledOSVersion = (string) content.GetValueForProperty("LastInstalledOSVersion",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastInstalledOSVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LastOSUpdateUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastOSUpdateUtc = (global::System.DateTime?) content.GetValueForProperty("LastOSUpdateUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastOSUpdateUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdateRequestUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastUpdateRequestUtc = (global::System.DateTime?) content.GetValueForProperty("LastUpdateRequestUtc",((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInternal)this).LastUpdateRequestUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Device" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Device" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDevice FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// An device resource belonging to a device group resource.
    [System.ComponentModel.TypeConverter(typeof(DeviceTypeConverter))]
    public partial interface IDevice

    {

    }
}