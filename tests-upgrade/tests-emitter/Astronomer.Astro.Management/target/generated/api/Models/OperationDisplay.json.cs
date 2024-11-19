// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Extensions;

    /// <summary>Localized display information for and operation.</summary>
    public partial class OperationDisplay
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOperationDisplay.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOperationDisplay.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IOperationDisplay FromJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json ? new OperationDisplay(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject into a new instance of <see cref="OperationDisplay" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OperationDisplay(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provider = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("provider"), out var __jsonProvider) ? (string)__jsonProvider : (string)_provider;}
            {_resource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("resource"), out var __jsonResource) ? (string)__jsonResource : (string)_resource;}
            {_operation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("operation"), out var __jsonOperation) ? (string)__jsonOperation : (string)_operation;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OperationDisplay" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OperationDisplay" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provider)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._provider.ToString()) : null, "provider" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._resource)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._resource.ToString()) : null, "resource" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._operation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._operation.ToString()) : null, "operation" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}