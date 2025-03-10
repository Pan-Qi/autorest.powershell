// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The list of disk configuration for vmSku which are part of SAP deployment.</summary>
    public partial class SapDiskConfigurationsResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsResultInternal
    {

        /// <summary>Backing field for <see cref="VolumeConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVolumeConfigurations _volumeConfiguration;

        /// <summary>
        /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
        /// 'os'], Optional volume : ['backup'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVolumeConfigurations VolumeConfiguration { get => (this._volumeConfiguration = this._volumeConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VolumeConfigurations()); set => this._volumeConfiguration = value; }

        /// <summary>Creates an new <see cref="SapDiskConfigurationsResult" /> instance.</summary>
        public SapDiskConfigurationsResult()
        {

        }
    }
    /// The list of disk configuration for vmSku which are part of SAP deployment.
    public partial interface ISapDiskConfigurationsResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
        /// 'os'], Optional volume : ['backup'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os'], Optional volume : ['backup'].",
        SerializedName = @"volumeConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVolumeConfigurations) })]
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVolumeConfigurations VolumeConfiguration { get; set; }

    }
    /// The list of disk configuration for vmSku which are part of SAP deployment.
    internal partial interface ISapDiskConfigurationsResultInternal

    {
        /// <summary>
        /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
        /// 'os'], Optional volume : ['backup'].
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVolumeConfigurations VolumeConfiguration { get; set; }

    }
}