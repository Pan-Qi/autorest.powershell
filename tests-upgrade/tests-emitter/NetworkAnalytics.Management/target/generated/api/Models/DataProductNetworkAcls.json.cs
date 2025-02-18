// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Data Product Network rule set</summary>
    public partial class DataProductNetworkAcls
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject into a new instance of <see cref="DataProductNetworkAcls" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DataProductNetworkAcls(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_virtualNetworkRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray>("virtualNetworkRule"), out var __jsonVirtualNetworkRule) ? If( __jsonVirtualNetworkRule as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule) (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.VirtualNetworkRule.FromJson(__u) )) ))() : null : _virtualNetworkRule;}
            {_iPRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray>("ipRules"), out var __jsonIPRules) ? If( __jsonIPRules as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules) (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPRules.FromJson(__p) )) ))() : null : _iPRule;}
            {_allowedQueryIPRangeList = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray>("allowedQueryIpRangeList"), out var __jsonAllowedQueryIPRangeList) ? If( __jsonAllowedQueryIPRangeList as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : _allowedQueryIPRangeList;}
            {_defaultAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("defaultAction"), out var __jsonDefaultAction) ? (string)__jsonDefaultAction : (string)_defaultAction;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json ? new DataProductNetworkAcls(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DataProductNetworkAcls" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DataProductNetworkAcls" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._virtualNetworkRule)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.XNodeArray();
                foreach( var __x in this._virtualNetworkRule )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("virtualNetworkRule",__w);
            }
            if (null != this._iPRule)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.XNodeArray();
                foreach( var __s in this._iPRule )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("ipRules",__r);
            }
            if (null != this._allowedQueryIPRangeList)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.XNodeArray();
                foreach( var __n in this._allowedQueryIPRangeList )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("allowedQueryIpRangeList",__m);
            }
            AddIf( null != (((object)this._defaultAction)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._defaultAction.ToString()) : null, "defaultAction" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}