// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the control family.</summary>
    public partial class ControlFamily :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamily,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamilyInternal
    {

        /// <summary>Backing field for <see cref="Control" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl> _control;

        /// <summary>List of controls.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl> Control { get => this._control; }

        /// <summary>Internal Acessors for Control</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamilyInternal.Control { get => this._control; set { {_control = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamilyInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlFamilyInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the control family. e.g. "Malware Protection - Anti-Virus"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The control family status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="ControlFamily" /> instance.</summary>
        public ControlFamily()
        {

        }
    }
    /// A class represent the control family.
    public partial interface IControlFamily :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of controls.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of controls.",
        SerializedName = @"controls",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl> Control { get;  }
        /// <summary>The name of the control family. e.g. "Malware Protection - Anti-Virus"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the control family. e.g. ""Malware Protection - Anti-Virus""",
        SerializedName = @"controlFamilyName",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The control family status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The control family status",
        SerializedName = @"controlFamilyStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get;  }

    }
    /// A class represent the control family.
    internal partial interface IControlFamilyInternal

    {
        /// <summary>List of controls.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControl> Control { get; set; }
        /// <summary>The name of the control family. e.g. "Malware Protection - Anti-Virus"</summary>
        string Name { get; set; }
        /// <summary>The control family status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Passed", "Failed", "NotApplicable", "PendingApproval")]
        string Status { get; set; }

    }
}