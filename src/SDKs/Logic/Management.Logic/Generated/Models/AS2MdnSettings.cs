// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AS2 agreement mdn settings.
    /// </summary>
    public partial class AS2MdnSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2MdnSettings class.
        /// </summary>
        public AS2MdnSettings() { }

        /// <summary>
        /// Initializes a new instance of the AS2MdnSettings class.
        /// </summary>
        /// <param name="needMdn">The value indicating whether to send or
        /// request a MDN.</param>
        /// <param name="signMdn">The value indicating whether the MDN needs to
        /// be signed or not.</param>
        /// <param name="sendMdnAsynchronously">The value indicating whether to
        /// send the asynchronous MDN.</param>
        /// <param name="signOutboundMdnIfOptional">The value indicating
        /// whether to sign the outbound MDN if optional.</param>
        /// <param name="sendInboundMdnToMessageBox">The value indicating
        /// whether to send inbound MDN to message box.</param>
        /// <param name="micHashingAlgorithm">The signing or hashing algorithm.
        /// Possible values include: 'NotSpecified', 'None', 'MD5', 'SHA1',
        /// 'SHA2256', 'SHA2384', 'SHA2512'</param>
        /// <param name="receiptDeliveryUrl">The receipt delivery URL.</param>
        /// <param name="dispositionNotificationTo">The disposition
        /// notification to header value.</param>
        /// <param name="mdnText">The MDN text.</param>
        public AS2MdnSettings(bool needMdn, bool signMdn, bool sendMdnAsynchronously, bool signOutboundMdnIfOptional, bool sendInboundMdnToMessageBox, HashingAlgorithm micHashingAlgorithm, string receiptDeliveryUrl = default(string), string dispositionNotificationTo = default(string), string mdnText = default(string))
        {
            NeedMdn = needMdn;
            SignMdn = signMdn;
            SendMdnAsynchronously = sendMdnAsynchronously;
            ReceiptDeliveryUrl = receiptDeliveryUrl;
            DispositionNotificationTo = dispositionNotificationTo;
            SignOutboundMdnIfOptional = signOutboundMdnIfOptional;
            MdnText = mdnText;
            SendInboundMdnToMessageBox = sendInboundMdnToMessageBox;
            MicHashingAlgorithm = micHashingAlgorithm;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to send or request a MDN.
        /// </summary>
        [JsonProperty(PropertyName = "needMdn")]
        public bool NeedMdn { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the MDN needs to be
        /// signed or not.
        /// </summary>
        [JsonProperty(PropertyName = "signMdn")]
        public bool SignMdn { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to send the asynchronous
        /// MDN.
        /// </summary>
        [JsonProperty(PropertyName = "sendMdnAsynchronously")]
        public bool SendMdnAsynchronously { get; set; }

        /// <summary>
        /// Gets or sets the receipt delivery URL.
        /// </summary>
        [JsonProperty(PropertyName = "receiptDeliveryUrl")]
        public string ReceiptDeliveryUrl { get; set; }

        /// <summary>
        /// Gets or sets the disposition notification to header value.
        /// </summary>
        [JsonProperty(PropertyName = "dispositionNotificationTo")]
        public string DispositionNotificationTo { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to sign the outbound MDN
        /// if optional.
        /// </summary>
        [JsonProperty(PropertyName = "signOutboundMdnIfOptional")]
        public bool SignOutboundMdnIfOptional { get; set; }

        /// <summary>
        /// Gets or sets the MDN text.
        /// </summary>
        [JsonProperty(PropertyName = "mdnText")]
        public string MdnText { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to send inbound MDN to
        /// message box.
        /// </summary>
        [JsonProperty(PropertyName = "sendInboundMdnToMessageBox")]
        public bool SendInboundMdnToMessageBox { get; set; }

        /// <summary>
        /// Gets or sets the signing or hashing algorithm. Possible values
        /// include: 'NotSpecified', 'None', 'MD5', 'SHA1', 'SHA2256',
        /// 'SHA2384', 'SHA2512'
        /// </summary>
        [JsonProperty(PropertyName = "micHashingAlgorithm")]
        public HashingAlgorithm MicHashingAlgorithm { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
