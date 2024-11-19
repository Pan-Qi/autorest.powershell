// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Astro.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Extensions;

    /// <summary>User assigned identity properties</summary>
    public partial class UserAssignedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserAssignedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserAssignedIdentityInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; }

        /// <summary>Internal Acessors for ClientId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserAssignedIdentityInternal.ClientId { get => this._clientId; set { {_clientId = value;} } }

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Astro.Models.IUserAssignedIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Origin(Microsoft.Azure.PowerShell.Cmdlets.Astro.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Creates an new <see cref="UserAssignedIdentity" /> instance.</summary>
        public UserAssignedIdentity()
        {

        }
    }
    /// User assigned identity properties
    public partial interface IUserAssignedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.IJsonSerializable
    {
        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The client ID of the assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get;  }
        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Astro.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The principal ID of the assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }

    }
    /// User assigned identity properties
    internal partial interface IUserAssignedIdentityInternal

    {
        /// <summary>The client ID of the assigned identity.</summary>
        string ClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        string PrincipalId { get; set; }

    }
}