using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Close balance create payments result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CloseBalanceResultModel
    {
        /// <summary>
        /// Created payments.
        /// </summary>
        [MessagePack.Key(0)]
        public required IEnumerable<AcceptedOrderPaymentModel> Payments { get; set; } = Enumerable.Empty<AcceptedOrderPaymentModel>();

        /// <summary>
        /// Optional expected payment model.
        /// </summary>
        [MessagePack.Key(1)]
        public ExpectedOrderPaymentModel? ExpectedPayment
        {
            get; init;
        }

        /// <summary>
        /// Closed invoices.
        /// </summary>
        [MessagePack.Key(2)]
        public required IEnumerable<CloseBalanceResultInvoiceModel> Invoices { get; init; } = Enumerable.Empty<CloseBalanceResultInvoiceModel>();
    } 
}
