// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A wrapper for account details to be used as a response.
    /// </summary>
    public partial class AccountDetailsWrapperList
    {
        /// <summary>
        /// Initializes a new instance of the AccountDetailsWrapperList class.
        /// </summary>
        public AccountDetailsWrapperList() { }

        /// <summary>
        /// Initializes a new instance of the AccountDetailsWrapperList class.
        /// </summary>
        public AccountDetailsWrapperList(IList<AccountDetailsWrapper> value = default(IList<AccountDetailsWrapper>))
        {
            Value = value;
        }

        /// <summary>
        /// Account properties
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AccountDetailsWrapper> Value { get; set; }

    }
}