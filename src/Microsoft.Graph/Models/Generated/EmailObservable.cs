// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EmailObservable.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EmailObservable
    {

        /// <summary>
        /// Gets or sets encoding.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encoding", Required = Newtonsoft.Json.Required.Default)]
        public string Encoding { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "language", Required = Newtonsoft.Json.Required.Default)]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or sets recipient.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient", Required = Newtonsoft.Json.Required.Default)]
        public string Recipient { get; set; }
    
        /// <summary>
        /// Gets or sets senderAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "senderAddress", Required = Newtonsoft.Json.Required.Default)]
        public string SenderAddress { get; set; }
    
        /// <summary>
        /// Gets or sets senderName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "senderName", Required = Newtonsoft.Json.Required.Default)]
        public string SenderName { get; set; }
    
        /// <summary>
        /// Gets or sets sourceDomain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceDomain", Required = Newtonsoft.Json.Required.Default)]
        public string SourceDomain { get; set; }
    
        /// <summary>
        /// Gets or sets sourceIPAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceIPAddress", Required = Newtonsoft.Json.Required.Default)]
        public string SourceIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets xmailer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "xmailer", Required = Newtonsoft.Json.Required.Default)]
        public string Xmailer { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}