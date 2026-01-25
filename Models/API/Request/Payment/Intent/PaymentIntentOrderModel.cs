using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent order model.
    /// </summary>
    /// <remarks>
    /// Describes order associated with intent, this model can represent both order and deposit intents.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentIntentOrderModel : IWebApiModel
    {
        /// <summary>
        /// Order intents.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentIntentOrderOrderModel> Orders { get; init; } = Enumerable.Empty<PaymentIntentOrderOrderModel>();

        /// <summary>
        /// Deposit intents.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<PaymentIntentOrderDepositModel> Deposits { get; init; } = Enumerable.Empty<PaymentIntentOrderDepositModel>();

        /// <summary>
        /// Invoice intents.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<PaymentIntentOrderInvoiceModel> Invoices { get; init; } = Enumerable.Empty<PaymentIntentOrderInvoiceModel>();
    }

    /// <summary>
    /// Payment intent order order model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentIntentOrderOrderModel : IWebApiModel
    {
        /// <summary>
        /// Product order id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderId { get; init; }
    }

    /// <summary>
    /// Payment intent order invoice model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentIntentOrderInvoiceModel : IWebApiModel
    {
        /// <summary>
        /// Invoice id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoiceId { get; init; }

        /// <summary>
        /// Product order id.
        /// </summary>
        [MessagePack.Key(1)]
        public int OrderId { get; init; }

        /// <summary>
        /// Receipt print status.
        /// </summary>
        [MessagePack.Key(2)]
        public Gizmo.Web.Api.Models.FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }

        /// <summary>
        /// Invoice payment.
        /// </summary>
        /// <remarks>
        /// Will be null if no payment is associated with intent.
        /// </remarks>
        [MessagePack.Key(3)]
        public PaymentIntentOrderInvoicePaymentModel? InvoicePayment { get; init; }
    }

    /// <summary>
    /// Payment intent order deposit model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentIntentOrderDepositModel : IWebApiModel
    {
        /// <summary>
        /// Deposit payment.
        /// </summary>
        /// <remarks>
        /// Will be null if no payment is associated with intent.
        /// </remarks>
        [MessagePack.Key(0)]
        public PaymentIntentOrderDepositPaymentModel? DepositPayment { get; init; }
    }

    /// <summary>
    /// Payment intent order deposit deposit payment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentIntentOrderDepositPaymentModel : IWebApiModel
    {
        /// <summary>
        /// Deposit payment id.
        /// </summary>
        /// <remarks>
        /// Null means that no deposit payment is associated with deposit intent.
        /// </remarks>
        [MessagePack.Key(0)]
        public int DepositPaymentId { get; init; }

        /// <summary>
        /// Receipt print status.
        /// </summary>
        [MessagePack.Key(1)]
        public Gizmo.Web.Api.Models.FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }
    }

    /// <summary>
    /// Payment intent order invoice invoice payment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentIntentOrderInvoicePaymentModel : IWebApiModel
    {
        /// <summary>
        /// Invoice payment id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoicePaymentId { get; init; }
    }
}
