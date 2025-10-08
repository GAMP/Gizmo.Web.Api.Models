using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart accept result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartAcceptResultModel
    {
        /// <summary>
        /// Created orders.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<AcceptedOrderModel> Orders { get; init; } = Enumerable.Empty<AcceptedOrderModel>();

        /// <summary>
        /// Associated payments.
        /// </summary>
        /// <remarks>
        /// Can be empty if no payments executed.
        /// </remarks>
        [MessagePack.Key(1)]
        public IEnumerable<AcceptedOrderPayment> Payments { get; init; } = Enumerable.Empty<AcceptedOrderPayment>();

        /// <summary>
        /// Associated payment intent.
        /// </summary>
        [MessagePack.Key(2)]
        public AcceptedOrderPayment? PaymentIntent { get; init; }
    }

    /// <summary>
    /// Accepted order model.
    /// </summary>
    /// <remarks>
    /// Model representing an order in context of cart accept operation.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class AcceptedOrderModel : IWebApiModel
    {
        /// <summary>
        /// Order id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderId { get; init; }

        /// <summary>
        /// Associated invoices.
        /// </summary>
        /// <remarks>
        /// Can be empty if no invoices where generated.
        /// </remarks>
        [MessagePack.Key(1)]
        public IEnumerable<AcceptedOrderInvoiceModel> Invoices { get; init; } = Enumerable.Empty<AcceptedOrderInvoiceModel>();  
    }

    /// <summary>
    /// Accepted order invoice model.
    /// </summary>
    /// <remarks>
    /// Model representing an invoice in context of cart accept operation.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class AcceptedOrderInvoiceModel
    {
        /// <summary>
        /// Invoice id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoiceId { get; init; }
    }

    /// <summary>
    /// Accepted order payment.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AcceptedOrderPayment
    {
        /// <summary>
        /// Payment id.
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentId { get;init; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(1)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Amount { get;init; }
    }

    /// <summary>
    /// Accept order payment intent.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AcceptOrderPaymentIntent
    {
        /// <summary>
        /// Payment intent id.
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentIntentId { get; set; }

        /// <summary>
        /// Payment intent guid.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; init; }
    }
}
