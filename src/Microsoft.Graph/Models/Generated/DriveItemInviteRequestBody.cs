// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DriveItemInviteRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DriveItemInviteRequestBody
    {
    
        /// <summary>
        /// Gets or sets RequireSignIn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSignIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets Roles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Roles { get; set; }
    
        /// <summary>
        /// Gets or sets SendInvitation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sendInvitation", Required = Newtonsoft.Json.Required.Default)]
        public bool? SendInvitation { get; set; }
    
        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "message", Required = Newtonsoft.Json.Required.Default)]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets Recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipients", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DriveRecipient> Recipients { get; set; }
    
        /// <summary>
        /// Gets or sets ExpirationDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public string ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "password", Required = Newtonsoft.Json.Required.Default)]
        public string Password { get; set; }
    
    }
}
