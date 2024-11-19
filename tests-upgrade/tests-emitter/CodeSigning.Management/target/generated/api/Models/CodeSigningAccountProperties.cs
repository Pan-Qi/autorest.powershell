// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Properties of the trusted signing account.</summary>
    public partial class CodeSigningAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AccountUri" /> property.</summary>
        private string _accountUri;

        /// <summary>The URI of the trusted signing account which is used during signing files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string AccountUri { get => this._accountUri; }

        /// <summary>Internal Acessors for AccountUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPropertiesInternal.AccountUri { get => this._accountUri; set { {_accountUri = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSku Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningAccountPropertiesInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.AccountSku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Status of the current operation on trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSku _sku;

        /// <summary>SKU of the trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.AccountSku()); set => this._sku = value; }

        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSkuInternal)Sku).Name = value ?? null; }

        /// <summary>Creates an new <see cref="CodeSigningAccountProperties" /> instance.</summary>
        public CodeSigningAccountProperties()
        {

        }
    }
    /// Properties of the trusted signing account.
    public partial interface ICodeSigningAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>The URI of the trusted signing account which is used during signing files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URI of the trusted signing account which is used during signing files.",
        SerializedName = @"accountUri",
        PossibleTypes = new [] { typeof(string) })]
        string AccountUri { get;  }
        /// <summary>Status of the current operation on trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the current operation on trusted signing account.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }

    }
    /// Properties of the trusted signing account.
    internal partial interface ICodeSigningAccountPropertiesInternal

    {
        /// <summary>The URI of the trusted signing account which is used during signing files.</summary>
        string AccountUri { get; set; }
        /// <summary>Status of the current operation on trusted signing account.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>SKU of the trusted signing account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IAccountSku Sku { get; set; }
        /// <summary>Name of the SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }

    }
}