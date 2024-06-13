using Gizmo.Web.Api.Models.Enumerations;
using System;

namespace Gizmo.Web.Api.Models.
{
    /// <summary>
    /// Active order model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActiveOrderModel : IWebApiModel
    {
        /// <summary>
        /// Gets order id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderId { get; init; }

        /// <summary>
        /// Invoice id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? InvoiceId { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserId { get; init; }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostId { get; init; }

        /// <summary>
        /// Total.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Total { get; init; } = decimal.Zero;

        /// <summary>
        /// Created time.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// Order status.
        /// </summary>
        [MessagePack.Key(6)]
        public ActiveOrderStatus Status { get; init; }

        /// <summary>
        /// Order payment status.
        /// </summary>
        [MessagePack.Key(7)]
        public ActiveOrderPaymentStatus PaymentStatus { get; init; }
    }
}
