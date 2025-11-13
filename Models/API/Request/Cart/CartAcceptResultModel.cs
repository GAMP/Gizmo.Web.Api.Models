using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart accept result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartAcceptResultModel : IWebApiModel
    {
        /// <summary>
        /// Created orders.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<AcceptedOrderModel> Orders { get; init; } = Enumerable.Empty<AcceptedOrderModel>();

        /// <summary>
        /// Processed payments.
        /// </summary>
        /// <remarks>
        /// Can be empty if no payments executed.
        /// </remarks>
        [MessagePack.Key(1)]
        public IEnumerable<AcceptedOrderPaymentModel> Payments { get; init; } = Enumerable.Empty<AcceptedOrderPaymentModel>();

        /// <summary>
        /// Expected payment.
        /// </summary>
        [MessagePack.Key(2)]
        public ExpectedOrderPaymentModel? ExpectedPayment { get; init; }

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
    public sealed class AcceptedOrderPaymentModel : IWebApiModel
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
    /// Expected payment model
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ExpectedOrderPaymentModel : IWebApiModel
    {
        /// <summary>
        /// Payment amount.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Payment intent id.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid IntentId { get; init; }

        /// <summary>
        /// Payment gateway type.
        /// </summary>
        [MessagePack.Key(2)]
        public PaymentGatewayType PaymentGatewayType { get; init; }
    }

}
