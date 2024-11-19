// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Properties of the certificate.</summary>
    public partial class Certificate :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal
    {

        /// <summary>Backing field for <see cref="CreatedDate" /> property.</summary>
        private string _createdDate;

        /// <summary>Certificate created date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string CreatedDate { get => this._createdDate; set => this._createdDate = value; }

        /// <summary>Backing field for <see cref="ExpiryDate" /> property.</summary>
        private string _expiryDate;

        /// <summary>Certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string ExpiryDate { get => this._expiryDate; set => this._expiryDate = value; }

        /// <summary>Internal Acessors for Revocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal.Revocation { get => (this._revocation = this._revocation ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Revocation()); set { {_revocation = value;} } }

        /// <summary>Backing field for <see cref="Revocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation _revocation;

        /// <summary>Revocations history of a certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation Revocation { get => (this._revocation = this._revocation ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Revocation()); set => this._revocation = value; }

        /// <summary>The timestamp when the revocation is effective.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public global::System.DateTime? RevocationEffectiveAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).EffectiveAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).EffectiveAt = value ?? default(global::System.DateTime); }

        /// <summary>Reason for the revocation failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string RevocationFailureReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).FailureReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).FailureReason = value ?? null; }

        /// <summary>Reason for revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string RevocationReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).Reason; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).Reason = value ?? null; }

        /// <summary>Remarks for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string RevocationRemark { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).Remark; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).Remark = value ?? null; }

        /// <summary>The timestamp when the revocation is requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public global::System.DateTime? RevocationRequestedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).RequestedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).RequestedAt = value ?? default(global::System.DateTime); }

        /// <summary>Status of the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string RevocationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal)Revocation).Status = value ?? null; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="SubjectName" /> property.</summary>
        private string _subjectName;

        /// <summary>Subject name of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string SubjectName { get => this._subjectName; set => this._subjectName = value; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>Thumbprint of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; set => this._thumbprint = value; }

        /// <summary>Creates an new <see cref="Certificate" /> instance.</summary>
        public Certificate()
        {

        }
    }
    /// Properties of the certificate.
    public partial interface ICertificate :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>Certificate created date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate created date.",
        SerializedName = @"createdDate",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedDate { get; set; }
        /// <summary>Certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate expiry date.",
        SerializedName = @"expiryDate",
        PossibleTypes = new [] { typeof(string) })]
        string ExpiryDate { get; set; }
        /// <summary>The timestamp when the revocation is effective.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp when the revocation is effective.",
        SerializedName = @"effectiveAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RevocationEffectiveAt { get; set; }
        /// <summary>Reason for the revocation failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reason for the revocation failure.",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string RevocationFailureReason { get; set; }
        /// <summary>Reason for revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reason for revocation.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string RevocationReason { get; set; }
        /// <summary>Remarks for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Remarks for the revocation.",
        SerializedName = @"remarks",
        PossibleTypes = new [] { typeof(string) })]
        string RevocationRemark { get; set; }
        /// <summary>The timestamp when the revocation is requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp when the revocation is requested.",
        SerializedName = @"requestedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RevocationRequestedAt { get; set; }
        /// <summary>Status of the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the revocation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "InProgress", "Failed")]
        string RevocationStatus { get; set; }
        /// <summary>Serial number of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serial number of the certificate.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>Status of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the certificate.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Active", "Expired", "Revoked")]
        string Status { get; set; }
        /// <summary>Subject name of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subject name of the certificate.",
        SerializedName = @"subjectName",
        PossibleTypes = new [] { typeof(string) })]
        string SubjectName { get; set; }
        /// <summary>Thumbprint of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Thumbprint of the certificate.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get; set; }

    }
    /// Properties of the certificate.
    internal partial interface ICertificateInternal

    {
        /// <summary>Certificate created date.</summary>
        string CreatedDate { get; set; }
        /// <summary>Certificate expiry date.</summary>
        string ExpiryDate { get; set; }
        /// <summary>Revocations history of a certificate.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation Revocation { get; set; }
        /// <summary>The timestamp when the revocation is effective.</summary>
        global::System.DateTime? RevocationEffectiveAt { get; set; }
        /// <summary>Reason for the revocation failure.</summary>
        string RevocationFailureReason { get; set; }
        /// <summary>Reason for revocation.</summary>
        string RevocationReason { get; set; }
        /// <summary>Remarks for the revocation.</summary>
        string RevocationRemark { get; set; }
        /// <summary>The timestamp when the revocation is requested.</summary>
        global::System.DateTime? RevocationRequestedAt { get; set; }
        /// <summary>Status of the revocation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "InProgress", "Failed")]
        string RevocationStatus { get; set; }
        /// <summary>Serial number of the certificate.</summary>
        string SerialNumber { get; set; }
        /// <summary>Status of the certificate.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Active", "Expired", "Revoked")]
        string Status { get; set; }
        /// <summary>Subject name of the certificate.</summary>
        string SubjectName { get; set; }
        /// <summary>Thumbprint of the certificate.</summary>
        string Thumbprint { get; set; }

    }
}