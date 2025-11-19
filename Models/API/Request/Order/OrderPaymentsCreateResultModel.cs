using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order payments create result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderPaymentsCreateResult : IWebApiModel
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
        /// Expected payment.
        /// </summary>
        [MessagePack.Key(2)]
        public ExpectedOrderPaymentModel? ExpectedPayment { get; init; }
    }
}
