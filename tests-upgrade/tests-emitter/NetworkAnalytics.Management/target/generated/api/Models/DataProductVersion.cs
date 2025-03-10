// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Data Product Version.</summary>
    public partial class DataProductVersion :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersion,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersionInternal
    {

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of data product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="DataProductVersion" /> instance.</summary>
        public DataProductVersion()
        {

        }
    }
    /// Data Product Version.
    public partial interface IDataProductVersion :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Version of data product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Version of data product",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Data Product Version.
    internal partial interface IDataProductVersionInternal

    {
        /// <summary>Version of data product</summary>
        string Version { get; set; }

    }
}