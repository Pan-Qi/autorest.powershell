// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
    /// </summary>
    public partial class SshPublicKey :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKey,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISshPublicKeyInternal
    {

        /// <summary>Backing field for <see cref="KeyData" /> property.</summary>
        private string _keyData;

        /// <summary>
        /// SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in
        /// ssh-rsa format. <br><br> For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string KeyData { get => this._keyData; set => this._keyData = value; }

        /// <summary>Creates an new <see cref="SshPublicKey" /> instance.</summary>
        public SshPublicKey()
        {

        }
    }
    /// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
    public partial interface ISshPublicKey :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in
        /// ssh-rsa format. <br><br> For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in ssh-rsa format. <br><br> For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).",
        SerializedName = @"keyData",
        PossibleTypes = new [] { typeof(string) })]
        string KeyData { get; set; }

    }
    /// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
    internal partial interface ISshPublicKeyInternal

    {
        /// <summary>
        /// SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in
        /// ssh-rsa format. <br><br> For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://learn.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed).
        /// </summary>
        string KeyData { get; set; }

    }
}