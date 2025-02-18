// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    public partial class StandbyPoolIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyPoolIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyPoolIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyPoolIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json ? new StandbyPoolIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject into a new instance of <see cref="StandbyPoolIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StandbyPoolIdentity(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)_subscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)_resourceGroupName;}
            {_standbyVirtualMachinePoolName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("standbyVirtualMachinePoolName"), out var __jsonStandbyVirtualMachinePoolName) ? (string)__jsonStandbyVirtualMachinePoolName : (string)_standbyVirtualMachinePoolName;}
            {_standbyVirtualMachineName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("standbyVirtualMachineName"), out var __jsonStandbyVirtualMachineName) ? (string)__jsonStandbyVirtualMachineName : (string)_standbyVirtualMachineName;}
            {_runtimeView = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("runtimeView"), out var __jsonRuntimeView) ? (string)__jsonRuntimeView : (string)_runtimeView;}
            {_standbyContainerGroupPoolName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("standbyContainerGroupPoolName"), out var __jsonStandbyContainerGroupPoolName) ? (string)__jsonStandbyContainerGroupPoolName : (string)_standbyContainerGroupPoolName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StandbyPoolIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StandbyPoolIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._standbyVirtualMachinePoolName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._standbyVirtualMachinePoolName.ToString()) : null, "standbyVirtualMachinePoolName" ,container.Add );
            AddIf( null != (((object)this._standbyVirtualMachineName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._standbyVirtualMachineName.ToString()) : null, "standbyVirtualMachineName" ,container.Add );
            AddIf( null != (((object)this._runtimeView)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._runtimeView.ToString()) : null, "runtimeView" ,container.Add );
            AddIf( null != (((object)this._standbyContainerGroupPoolName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._standbyContainerGroupPoolName.ToString()) : null, "standbyContainerGroupPoolName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}