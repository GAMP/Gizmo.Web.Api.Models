﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class OrderCalculatePaymentModelOptions : IOrderCalculateOptionsModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [Key(0)]
        public int? PreferredPaymentMethodId { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(1)]
        public IEnumerable<OrderLineModelOptions>? OrderLines { get; set; }

        #endregion
    }
}