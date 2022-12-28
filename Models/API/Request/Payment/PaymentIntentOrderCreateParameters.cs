﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Payment
{
    /// <summary>
    /// Order intent creation parameters.
    /// </summary>
    [MessagePackObject]
    public sealed class PaymentIntentOrderCreateParameters : IPaymentIntentCreateParametersApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets intent order id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets intent user id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets intent amount.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        /// <remarks>
        /// The method must have payment provider set, otherwise operation will fail.
        /// </remarks>
        [MessagePack.Key(3)]
        public int PaymentMethodId { get; set; }

        #endregion
    }
}
