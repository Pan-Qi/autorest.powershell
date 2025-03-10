// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Scoping question list.</summary>
    public partial class ScopingQuestions :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestions,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionsInternal
    {

        /// <summary>Backing field for <see cref="Question" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion> _question;

        /// <summary>List of scoping questions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion> Question { get => this._question; set => this._question = value; }

        /// <summary>Creates an new <see cref="ScopingQuestions" /> instance.</summary>
        public ScopingQuestions()
        {

        }
    }
    /// Scoping question list.
    public partial interface IScopingQuestions :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of scoping questions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of scoping questions.",
        SerializedName = @"questions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion> Question { get; set; }

    }
    /// Scoping question list.
    internal partial interface IScopingQuestionsInternal

    {
        /// <summary>List of scoping questions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion> Question { get; set; }

    }
}