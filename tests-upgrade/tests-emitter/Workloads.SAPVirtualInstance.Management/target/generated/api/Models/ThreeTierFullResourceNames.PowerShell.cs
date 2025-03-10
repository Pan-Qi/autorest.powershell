// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a three
    /// tier SAP system.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ThreeTierFullResourceNamesTypeConverter))]
    public partial class ThreeTierFullResourceNames
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNames" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNames DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ThreeTierFullResourceNames(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNames" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNames DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ThreeTierFullResourceNames(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ThreeTierFullResourceNames" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ThreeTierFullResourceNames" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNames FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ThreeTierFullResourceNames(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CentralServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNames) content.GetValueForProperty("CentralServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerFullResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames) content.GetValueForProperty("ApplicationServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerFullResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames) content.GetValueForProperty("DatabaseServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SharedStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorage = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames) content.GetValueForProperty("SharedStorage",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorage, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SharedStorageResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)this).NamingPatternType = (string) content.GetValueForProperty("NamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)this).NamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerVirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("CentralServerVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerVirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApplicationServerVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerVirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("ApplicationServerVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerVirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("DatabaseServerVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerVirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("DatabaseServerVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerVirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("CentralServerLoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames) content.GetValueForProperty("CentralServerLoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServerAvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerAvailabilitySetName = (string) content.GetValueForProperty("CentralServerAvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerAvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerAvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerAvailabilitySetName = (string) content.GetValueForProperty("ApplicationServerAvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerAvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerLoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames) content.GetValueForProperty("DatabaseServerLoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerAvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerAvailabilitySetName = (string) content.GetValueForProperty("DatabaseServerAvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerAvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("SharedStorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountName = (string) content.GetValueForProperty("SharedStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("SharedStorageAccountPrivateEndPointName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountPrivateEndPointName = (string) content.GetValueForProperty("SharedStorageAccountPrivateEndPointName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountPrivateEndPointName, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerLoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerName = (string) content.GetValueForProperty("CentralServerLoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerLoadBalancerFrontendIPConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerFrontendIPConfigurationName = (System.Collections.Generic.List<string>) content.GetValueForProperty("CentralServerLoadBalancerFrontendIPConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerFrontendIPConfigurationName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CentralServerLoadBalancerBackendPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerBackendPoolName = (System.Collections.Generic.List<string>) content.GetValueForProperty("CentralServerLoadBalancerBackendPoolName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerBackendPoolName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CentralServerLoadBalancerHealthProbeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerHealthProbeName = (System.Collections.Generic.List<string>) content.GetValueForProperty("CentralServerLoadBalancerHealthProbeName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerHealthProbeName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseServerLoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerName = (string) content.GetValueForProperty("DatabaseServerLoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerLoadBalancerFrontendIPConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerFrontendIPConfigurationName = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatabaseServerLoadBalancerFrontendIPConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerFrontendIPConfigurationName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseServerLoadBalancerBackendPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerBackendPoolName = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatabaseServerLoadBalancerBackendPoolName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerBackendPoolName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseServerLoadBalancerHealthProbeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerHealthProbeName = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatabaseServerLoadBalancerHealthProbeName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerHealthProbeName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierFullResourceNames"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ThreeTierFullResourceNames(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CentralServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNames) content.GetValueForProperty("CentralServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerFullResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames) content.GetValueForProperty("ApplicationServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerFullResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames) content.GetValueForProperty("DatabaseServer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SharedStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorage = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames) content.GetValueForProperty("SharedStorage",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorage, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SharedStorageResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NamingPatternType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)this).NamingPatternType = (string) content.GetValueForProperty("NamingPatternType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)this).NamingPatternType, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerVirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("CentralServerVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerVirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApplicationServerVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerVirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("ApplicationServerVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerVirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("DatabaseServerVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerVirtualMachine = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>) content.GetValueForProperty("DatabaseServerVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerVirtualMachine, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames>(__y, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNamesTypeConverter.ConvertFrom));
            }
            if (content.Contains("CentralServerLoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames) content.GetValueForProperty("CentralServerLoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CentralServerAvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerAvailabilitySetName = (string) content.GetValueForProperty("CentralServerAvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerAvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerAvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerAvailabilitySetName = (string) content.GetValueForProperty("ApplicationServerAvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).ApplicationServerAvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerLoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancer = (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames) content.GetValueForProperty("DatabaseServerLoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancer, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNamesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatabaseServerAvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerAvailabilitySetName = (string) content.GetValueForProperty("DatabaseServerAvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerAvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("SharedStorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountName = (string) content.GetValueForProperty("SharedStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("SharedStorageAccountPrivateEndPointName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountPrivateEndPointName = (string) content.GetValueForProperty("SharedStorageAccountPrivateEndPointName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).SharedStorageAccountPrivateEndPointName, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerLoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerName = (string) content.GetValueForProperty("CentralServerLoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerLoadBalancerFrontendIPConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerFrontendIPConfigurationName = (System.Collections.Generic.List<string>) content.GetValueForProperty("CentralServerLoadBalancerFrontendIPConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerFrontendIPConfigurationName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CentralServerLoadBalancerBackendPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerBackendPoolName = (System.Collections.Generic.List<string>) content.GetValueForProperty("CentralServerLoadBalancerBackendPoolName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerBackendPoolName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CentralServerLoadBalancerHealthProbeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerHealthProbeName = (System.Collections.Generic.List<string>) content.GetValueForProperty("CentralServerLoadBalancerHealthProbeName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).CentralServerLoadBalancerHealthProbeName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseServerLoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerName = (string) content.GetValueForProperty("DatabaseServerLoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseServerLoadBalancerFrontendIPConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerFrontendIPConfigurationName = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatabaseServerLoadBalancerFrontendIPConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerFrontendIPConfigurationName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseServerLoadBalancerBackendPoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerBackendPoolName = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatabaseServerLoadBalancerBackendPoolName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerBackendPoolName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatabaseServerLoadBalancerHealthProbeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerHealthProbeName = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatabaseServerLoadBalancerHealthProbeName",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal)this).DatabaseServerLoadBalancerHealthProbeName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

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
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a three
    /// tier SAP system.
    [System.ComponentModel.TypeConverter(typeof(ThreeTierFullResourceNamesTypeConverter))]
    public partial interface IThreeTierFullResourceNames

    {

    }
}