// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the SAP message server properties.</summary>
    public partial class MessageServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private string _health;

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Health { get => this._health; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>message server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; }

        /// <summary>Backing field for <see cref="HttpPort" /> property.</summary>
        private long? _httpPort;

        /// <summary>message server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? HttpPort { get => this._httpPort; }

        /// <summary>Backing field for <see cref="HttpsPort" /> property.</summary>
        private long? _httpsPort;

        /// <summary>message server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? HttpsPort { get => this._httpsPort; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="InternalMSPort" /> property.</summary>
        private long? _internalMSPort;

        /// <summary>message server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? InternalMSPort { get => this._internalMSPort; }

        /// <summary>Backing field for <see cref="MSPort" /> property.</summary>
        private long? _mSPort;

        /// <summary>message server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? MSPort { get => this._mSPort; }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for Hostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.Hostname { get => this._hostname; set { {_hostname = value;} } }

        /// <summary>Internal Acessors for HttpPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.HttpPort { get => this._httpPort; set { {_httpPort = value;} } }

        /// <summary>Internal Acessors for HttpsPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.HttpsPort { get => this._httpsPort; set { {_httpsPort = value;} } }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for InternalMSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.InternalMSPort { get => this._internalMSPort; set { {_internalMSPort = value;} } }

        /// <summary>Internal Acessors for MSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IMessageServerPropertiesInternal.MSPort { get => this._mSPort; set { {_mSPort = value;} } }

        /// <summary>Creates an new <see cref="MessageServerProperties" /> instance.</summary>
        public MessageServerProperties()
        {

        }
    }
    /// Defines the SAP message server properties.
    public partial interface IMessageServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the health of SAP Instances.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get;  }
        /// <summary>message server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server SAP Hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get;  }
        /// <summary>message server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server HTTP Port.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(long) })]
        long? HttpPort { get;  }
        /// <summary>message server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server HTTPS Port.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? HttpsPort { get;  }
        /// <summary>message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get;  }
        /// <summary>message server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server internal MS port.",
        SerializedName = @"internalMsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? InternalMSPort { get;  }
        /// <summary>message server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"message server port.",
        SerializedName = @"msPort",
        PossibleTypes = new [] { typeof(long) })]
        long? MSPort { get;  }

    }
    /// Defines the SAP message server properties.
    internal partial interface IMessageServerPropertiesInternal

    {
        /// <summary>Defines the health of SAP Instances.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Unknown", "Healthy", "Unhealthy", "Degraded")]
        string Health { get; set; }
        /// <summary>message server SAP Hostname.</summary>
        string Hostname { get; set; }
        /// <summary>message server HTTP Port.</summary>
        long? HttpPort { get; set; }
        /// <summary>message server HTTPS Port.</summary>
        long? HttpsPort { get; set; }
        /// <summary>message server IP Address.</summary>
        string IPAddress { get; set; }
        /// <summary>message server internal MS port.</summary>
        long? InternalMSPort { get; set; }
        /// <summary>message server port.</summary>
        long? MSPort { get; set; }

    }
}