using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order intent payments create result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderIntentPaymentsCreateResult : IWebApiModel
    {
        /// <summary>
        /// Created payments.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<AcceptedOrderPaymentModel> Payments { get; set; } = Enumerable.Empty<AcceptedOrderPaymentModel>();

        /// <summary>
        /// Created invoices.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<AcceptedOrderInvoiceModel> Invoices { get; set; } = Enumerable.Empty<AcceptedOrderInvoiceModel>();

        /// <summary>
        /// Processed deposit payments.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<AcceptedDepositPaymentModel> DepositPayments { get; init; } = Enumerable.Empty<AcceptedDepositPaymentModel>();

        /// <summary>
        /// Expected payment.
        /// </summary>
        [MessagePack.Key(3)]
        public ExpectedOrderPaymentModel? ExpectedPayment { get; init; }
    }
}
