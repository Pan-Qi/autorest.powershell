// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Stop SAP instance(s) request body.</summary>
    public partial class StopRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStopRequest,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStopRequestInternal
    {

        /// <summary>Backing field for <see cref="DeallocateVM" /> property.</summary>
        private bool? _deallocateVM;

        /// <summary>
        /// The boolean value indicates whether to Stop and deallocate the virtual machines along with the SAP instances.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public bool? DeallocateVM { get => this._deallocateVM; set => this._deallocateVM = value; }

        /// <summary>Backing field for <see cref="SoftStopTimeoutSecond" /> property.</summary>
        private long? _softStopTimeoutSecond;

        /// <summary>
        /// This parameter defines how long (in seconds) the soft shutdown waits until the RFC/HTTP clients no longer consider the
        /// server for calls with load balancing. Value 0 means that the kernel does not wait, but goes directly into the next shutdown
        /// state, i.e. hard stop.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? SoftStopTimeoutSecond { get => this._softStopTimeoutSecond; set => this._softStopTimeoutSecond = value; }

        /// <summary>Creates an new <see cref="StopRequest" /> instance.</summary>
        public StopRequest()
        {

        }
    }
    /// Stop SAP instance(s) request body.
    public partial interface IStopRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The boolean value indicates whether to Stop and deallocate the virtual machines along with the SAP instances.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The boolean value indicates whether to Stop and deallocate the virtual machines along with the SAP instances.",
        SerializedName = @"deallocateVm",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DeallocateVM { get; set; }
        /// <summary>
        /// This parameter defines how long (in seconds) the soft shutdown waits until the RFC/HTTP clients no longer consider the
        /// server for calls with load balancing. Value 0 means that the kernel does not wait, but goes directly into the next shutdown
        /// state, i.e. hard stop.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This parameter defines how long (in seconds) the soft shutdown waits until the RFC/HTTP clients no longer consider the server for calls with load balancing. Value 0 means that the kernel does not wait, but goes directly into the next shutdown state, i.e. hard stop.",
        SerializedName = @"softStopTimeoutSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? SoftStopTimeoutSecond { get; set; }

    }
    /// Stop SAP instance(s) request body.
    internal partial interface IStopRequestInternal

    {
        /// <summary>
        /// The boolean value indicates whether to Stop and deallocate the virtual machines along with the SAP instances.
        /// </summary>
        bool? DeallocateVM { get; set; }
        /// <summary>
        /// This parameter defines how long (in seconds) the soft shutdown waits until the RFC/HTTP clients no longer consider the
        /// server for calls with load balancing. Value 0 means that the kernel does not wait, but goes directly into the next shutdown
        /// state, i.e. hard stop.
        /// </summary>
        long? SoftStopTimeoutSecond { get; set; }

    }
}