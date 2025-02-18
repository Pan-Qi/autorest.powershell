// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Represents the profile for a single additional location in the Fleet. The location and the virtualMachineProfileOverride
    /// (optional).
    /// </summary>
    public partial class LocationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILocationProfileInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>
        /// The ARM location name of the additional region. If LocationProfile is specified, then location is required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="VirtualMachineProfileOverride" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile _virtualMachineProfileOverride;

        /// <summary>
        /// An override for computeProfile.baseVirtualMachineProfile specific to this region.
        /// This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources
        /// deployed in this location.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile VirtualMachineProfileOverride { get => (this._virtualMachineProfileOverride = this._virtualMachineProfileOverride ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.BaseVirtualMachineProfile()); set => this._virtualMachineProfileOverride = value; }

        /// <summary>Creates an new <see cref="LocationProfile" /> instance.</summary>
        public LocationProfile()
        {

        }
    }
    /// Represents the profile for a single additional location in the Fleet. The location and the virtualMachineProfileOverride
    /// (optional).
    public partial interface ILocationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The ARM location name of the additional region. If LocationProfile is specified, then location is required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM location name of the additional region. If LocationProfile is specified, then location is required.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>
        /// An override for computeProfile.baseVirtualMachineProfile specific to this region.
        /// This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources
        /// deployed in this location.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An override for computeProfile.baseVirtualMachineProfile specific to this region.
        This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources deployed in this location.",
        SerializedName = @"virtualMachineProfileOverride",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile VirtualMachineProfileOverride { get; set; }

    }
    /// Represents the profile for a single additional location in the Fleet. The location and the virtualMachineProfileOverride
    /// (optional).
    internal partial interface ILocationProfileInternal

    {
        /// <summary>
        /// The ARM location name of the additional region. If LocationProfile is specified, then location is required.
        /// </summary>
        string Location { get; set; }
        /// <summary>
        /// An override for computeProfile.baseVirtualMachineProfile specific to this region.
        /// This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources
        /// deployed in this location.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile VirtualMachineProfileOverride { get; set; }

    }
}