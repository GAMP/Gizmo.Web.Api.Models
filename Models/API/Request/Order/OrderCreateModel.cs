using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculated order model.
    /// </summary>
    /// <remarks>
    /// This model is used when we want to create a custom calculated order where order lines are precalculated and modified.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class OrderCreateModel : IWebApiModel
    {
        /// <summary>
        /// Unique client side request identification of order.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        /// <remarks>
        /// Null indicates guest sale.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? UserId
        {
            get; init;
        }

        /// <summary>
        /// Optional user note.
        /// </summary>
        /// <remarks>
        /// Right now its only used when order is posted from client by user.
        /// </remarks>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string? UserNote
        {
            get; init;
        }

        /// <summary>
        /// Gets order lines.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<IOrderLineCreateModel> OrderLines { get; init; } = [];

        /// <summary>
        /// Optional invoice payments.
        /// </summary>
        [MessagePack.Key(4)]
        public IEnumerable<PaymentCreateModel> Payments
        {
            get; init;
        } = [];
    }
}
