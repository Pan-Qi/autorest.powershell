// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The recommended configuration for a three tier SAP system.</summary>
    public partial class ThreeTierRecommendationResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult __sapSizingRecommendationResult = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapSizingRecommendationResult();

        /// <summary>Backing field for <see cref="ApplicationServerInstanceCount" /> property.</summary>
        private long? _applicationServerInstanceCount;

        /// <summary>The application server instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? ApplicationServerInstanceCount { get => this._applicationServerInstanceCount; set => this._applicationServerInstanceCount = value; }

        /// <summary>Backing field for <see cref="ApplicationServerVMSku" /> property.</summary>
        private string _applicationServerVMSku;

        /// <summary>The application server VM SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string ApplicationServerVMSku { get => this._applicationServerVMSku; set => this._applicationServerVMSku = value; }

        /// <summary>Backing field for <see cref="CentralServerInstanceCount" /> property.</summary>
        private long? _centralServerInstanceCount;

        /// <summary>The central server instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? CentralServerInstanceCount { get => this._centralServerInstanceCount; set => this._centralServerInstanceCount = value; }

        /// <summary>Backing field for <see cref="CentralServerVMSku" /> property.</summary>
        private string _centralServerVMSku;

        /// <summary>The central server VM SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string CentralServerVMSku { get => this._centralServerVMSku; set => this._centralServerVMSku = value; }

        /// <summary>Backing field for <see cref="DatabaseInstanceCount" /> property.</summary>
        private long? _databaseInstanceCount;

        /// <summary>The database server instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? DatabaseInstanceCount { get => this._databaseInstanceCount; set => this._databaseInstanceCount = value; }

        /// <summary>Backing field for <see cref="DbVMSku" /> property.</summary>
        private string _dbVMSku;

        /// <summary>The database VM SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DbVMSku { get => this._dbVMSku; set => this._dbVMSku = value; }

        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string DeploymentType { get => "ThreeTier"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal)__sapSizingRecommendationResult).DeploymentType = "ThreeTier"; }

        /// <summary>Creates an new <see cref="ThreeTierRecommendationResult" /> instance.</summary>
        public ThreeTierRecommendationResult()
        {
            this.__sapSizingRecommendationResult.DeploymentType = "ThreeTier";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__sapSizingRecommendationResult), __sapSizingRecommendationResult);
            await eventListener.AssertObjectIsValid(nameof(__sapSizingRecommendationResult), __sapSizingRecommendationResult);
        }
    }
    /// The recommended configuration for a three tier SAP system.
    public partial interface IThreeTierRecommendationResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult
    {
        /// <summary>The application server instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The application server instance count.",
        SerializedName = @"applicationServerInstanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? ApplicationServerInstanceCount { get; set; }
        /// <summary>The application server VM SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The application server VM SKU.",
        SerializedName = @"applicationServerVmSku",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerVMSku { get; set; }
        /// <summary>The central server instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The central server instance count.",
        SerializedName = @"centralServerInstanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? CentralServerInstanceCount { get; set; }
        /// <summary>The central server VM SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The central server VM SKU.",
        SerializedName = @"centralServerVmSku",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerVMSku { get; set; }
        /// <summary>The database server instance count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The database server instance count.",
        SerializedName = @"databaseInstanceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? DatabaseInstanceCount { get; set; }
        /// <summary>The database VM SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The database VM SKU.",
        SerializedName = @"dbVmSku",
        PossibleTypes = new [] { typeof(string) })]
        string DbVMSku { get; set; }

    }
    /// The recommended configuration for a three tier SAP system.
    internal partial interface IThreeTierRecommendationResultInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal
    {
        /// <summary>The application server instance count.</summary>
        long? ApplicationServerInstanceCount { get; set; }
        /// <summary>The application server VM SKU.</summary>
        string ApplicationServerVMSku { get; set; }
        /// <summary>The central server instance count.</summary>
        long? CentralServerInstanceCount { get; set; }
        /// <summary>The central server VM SKU.</summary>
        string CentralServerVMSku { get; set; }
        /// <summary>The database server instance count.</summary>
        long? DatabaseInstanceCount { get; set; }
        /// <summary>The database VM SKU.</summary>
        string DbVMSku { get; set; }

    }
}