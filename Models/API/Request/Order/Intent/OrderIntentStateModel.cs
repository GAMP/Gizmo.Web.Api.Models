using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order intent state model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderIntentStateModel : IWebApiModel
    {
        /// <summary>
        /// Sub total.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal SubTotal { get; init; }

        /// <summary>
        /// Tax total.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal TaxTotal { get; init; }

        /// <summary>
        /// Fee total.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal FeeTotal { get; init; }

        /// <summary>
        /// Discount total.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal DiscountTotal { get; init; }

        /// <summary>
        /// Total.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Total { get; init; }

        /// <summary>
        /// Outstanding amount.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Outstanding { get; init; }

        /// <summary>
        /// Users.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<OrderIntentUserModel> Users { get; set; } = Array.Empty<OrderIntentUserModel>();

        /// <summary>
        /// Payment intent state.
        /// </summary>
        [MessagePack.Key(7)]
        public PaymentIntentState IntentState { get; init; }

        /// <summary>
        /// Intent amount total.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal IntentAmount { get; init; }
    }
}
