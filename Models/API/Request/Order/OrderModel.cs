using Gizmo.Web.Api.Models.Abstractions;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class OrderModel : IModelIntIdentifier , IWebApiModel
    {
        /// <summary>
        /// Product order id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Shift id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ShiftId { get; init; }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? RegisterId { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BranchId { get; init; }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? HostId { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(5)]
        public int UserId { get; init; }

        /// <summary>
        /// Created by id.
        /// </summary>
        [MessagePack.Key(6)]
        public int? CreatedById { get; init; }

        /// <summary>
        /// Order sub total.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal SubTotal { get; init; }

        /// <summary>
        /// Order tax total.
        /// </summary>

        [MessagePack.Key(8)]
        public decimal TaxTotal { get; init; }

        /// <summary>
        /// Order total.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Total { get; init; }

        /// <summary>
        /// Order outstanding amount.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal Outstanding { get; init; }

        /// <summary>
        /// Indicates that order is voided.
        /// </summary>
        /// <remarks>
        /// This value will be true if all invoices of the order are voided.
        /// </remarks>
        [MessagePack.Key(11)]
        public OrderVoidStatus VoidStatus { get; init; }

        /// <summary>
        /// Invoice payment status.
        /// </summary>
        [MessagePack.Key(12)]
        public InvoiceStatus PaymentStatus { get; init; }

        /// <summary>
        /// Order delivery status.
        /// </summary>
        [MessagePack.Key(13)]
        public OrderDeliveryStatus DeliveryStatus { get; init; }

        /// <summary>
        /// Refund status.
        /// </summary>
        [MessagePack.Key(14)]
        public RefundStatus RefundStatus { get; init; }

        /// <summary>
        /// Order status.
        /// </summary>
        [MessagePack.Key(15)]
        public OrderStatus Status { get; init; }

        /// <summary>
        /// Creation date.
        /// </summary>
        [MessagePack.Key(16)]
        public DateTime Date { get; init; }

        /// <summary>
        /// Payment expected flag.
        /// </summary>
        /// <remarks>
        /// Will be set if there is at least one payment intent pending for the order.
        /// </remarks>
        [MessagePack.Key(17)]
        public bool PaymentExpected { get; init; }

        /// <summary>
        /// Preferred payment method id.
        /// </summary>
        [MessagePack.Key(18)]
        public int? PreferredPaymentMethodId { get; init; }

        /// <summary>
        /// Order source.
        /// </summary>
        [MessagePack.Key(19)]
        public OrderSource Source { get; init; }

        /// <summary>
        /// Indicates that order has note.
        /// </summary>
        [MessagePack.Key(20)]
        public bool HasNote { get; init; }
    }
}
