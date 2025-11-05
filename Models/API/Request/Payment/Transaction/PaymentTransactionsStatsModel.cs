using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction stats model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionsStatsModel : IWebApiModel
    {
        /// <summary>
        /// Incoming transactions.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentTransactionStatPaymentModel> Incoming { get; set; } = Enumerable.Empty<PaymentTransactionStatPaymentModel>();

        /// <summary>
        /// Outgoing transactions.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<PaymentTransactionStatPaymentModel> Outgoing { get; set; } = Enumerable.Empty<PaymentTransactionStatPaymentModel>();

        /// <summary>
        /// Outstanding.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Outstanding { get; init; }
    }
}
