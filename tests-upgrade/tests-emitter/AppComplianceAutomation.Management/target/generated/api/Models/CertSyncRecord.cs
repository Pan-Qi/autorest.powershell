// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the certification record synchronized from app compliance.</summary>
    public partial class CertSyncRecord :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecord,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ICertSyncRecordInternal
    {

        /// <summary>Backing field for <see cref="CertificationStatus" /> property.</summary>
        private string _certificationStatus;

        /// <summary>Indicates the status of certification process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string CertificationStatus { get => this._certificationStatus; set => this._certificationStatus = value; }

        /// <summary>Backing field for <see cref="Control" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> _control;

        /// <summary>The control records list to be synchronized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> Control { get => this._control; set => this._control = value; }

        /// <summary>Backing field for <see cref="IngestionStatus" /> property.</summary>
        private string _ingestionStatus;

        /// <summary>Indicates the status of compliance process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string IngestionStatus { get => this._ingestionStatus; set => this._ingestionStatus = value; }

        /// <summary>Backing field for <see cref="OfferGuid" /> property.</summary>
        private string _offerGuid;

        /// <summary>The offerGuid which mapping to the reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string OfferGuid { get => this._offerGuid; set => this._offerGuid = value; }

        /// <summary>Creates an new <see cref="CertSyncRecord" /> instance.</summary>
        public CertSyncRecord()
        {

        }
    }
    /// A class represent the certification record synchronized from app compliance.
    public partial interface ICertSyncRecord :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the status of certification process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the status of certification process.",
        SerializedName = @"certificationStatus",
        PossibleTypes = new [] { typeof(string) })]
        string CertificationStatus { get; set; }
        /// <summary>The control records list to be synchronized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The control records list to be synchronized.",
        SerializedName = @"controls",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> Control { get; set; }
        /// <summary>Indicates the status of compliance process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the status of compliance process.",
        SerializedName = @"ingestionStatus",
        PossibleTypes = new [] { typeof(string) })]
        string IngestionStatus { get; set; }
        /// <summary>The offerGuid which mapping to the reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The offerGuid which mapping to the reports.",
        SerializedName = @"offerGuid",
        PossibleTypes = new [] { typeof(string) })]
        string OfferGuid { get; set; }

    }
    /// A class represent the certification record synchronized from app compliance.
    internal partial interface ICertSyncRecordInternal

    {
        /// <summary>Indicates the status of certification process.</summary>
        string CertificationStatus { get; set; }
        /// <summary>The control records list to be synchronized.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord> Control { get; set; }
        /// <summary>Indicates the status of compliance process.</summary>
        string IngestionStatus { get; set; }
        /// <summary>The offerGuid which mapping to the reports.</summary>
        string OfferGuid { get; set; }

    }
}