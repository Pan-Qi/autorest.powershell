// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set extension profile.</summary>
    public partial class VirtualMachineScaleSetExtensionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionProfileInternal
    {

        /// <summary>Backing field for <see cref="Extension" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtension> _extension;

        /// <summary>The virtual machine scale set child extension resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtension> Extension { get => this._extension; set => this._extension = value; }

        /// <summary>Backing field for <see cref="ExtensionsTimeBudget" /> property.</summary>
        private string _extensionsTimeBudget;

        /// <summary>
        /// Specifies the time alloted for all extensions to start. The time duration
        /// should be between 15 minutes and 120 minutes (inclusive) and should be
        /// specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).
        /// Minimum api-version: 2020-06-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ExtensionsTimeBudget { get => this._extensionsTimeBudget; set => this._extensionsTimeBudget = value; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetExtensionProfile" /> instance.</summary>
        public VirtualMachineScaleSetExtensionProfile()
        {

        }
    }
    /// Describes a virtual machine scale set extension profile.
    public partial interface IVirtualMachineScaleSetExtensionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The virtual machine scale set child extension resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The virtual machine scale set child extension resources.",
        SerializedName = @"extensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtension) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtension> Extension { get; set; }
        /// <summary>
        /// Specifies the time alloted for all extensions to start. The time duration
        /// should be between 15 minutes and 120 minutes (inclusive) and should be
        /// specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).
        /// Minimum api-version: 2020-06-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the time alloted for all extensions to start. The time duration
        should be between 15 minutes and 120 minutes (inclusive) and should be
        specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).
        Minimum api-version: 2020-06-01.",
        SerializedName = @"extensionsTimeBudget",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionsTimeBudget { get; set; }

    }
    /// Describes a virtual machine scale set extension profile.
    internal partial interface IVirtualMachineScaleSetExtensionProfileInternal

    {
        /// <summary>The virtual machine scale set child extension resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtension> Extension { get; set; }
        /// <summary>
        /// Specifies the time alloted for all extensions to start. The time duration
        /// should be between 15 minutes and 120 minutes (inclusive) and should be
        /// specified in ISO 8601 format. The default value is 90 minutes (PT1H30M).
        /// Minimum api-version: 2020-06-01.
        /// </summary>
        string ExtensionsTimeBudget { get; set; }

    }
}