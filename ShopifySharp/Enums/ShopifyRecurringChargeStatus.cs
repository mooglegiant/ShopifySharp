﻿using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    // TODO: Merge this enum with ShopifyChargeStatus in v2.0

    /// <summary>
    /// An enum that indicates the status of a <see cref="ShopifyRecurringCharge"/> object.
    /// </summary>
    [JsonConverter(typeof(ShopifyRecurringChargeConverter))]
    public enum ShopifyRecurringChargeStatus
    {
        /// <summary>
        /// The charge is pending and has not been accepted or declined by the user.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// The charge has been accepted by the user and can be activated.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// The charge has been accepted and activated.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// The charge has been cancelled.
        /// </summary>
        [EnumMember(Value ="cancelled")]
        Cancelled,

        /// <summary>
        /// The charge has been declined by the user and cannot be activated.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,

        /// <summary>
        /// The charge has expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// The status of the charge is unknown. This is an invalid value. If possible, submit a 
        /// pull request to https://github.com/nozzlegear/shopifysharp with the correct value.
        /// </summary>
        [EnumMember(Value = "")]
        Unknown
    }
}
