using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Multiple orders creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoiceCreateMultiResultModel : IWebApiModel
    {
        /// <summary>
        /// Order creation results.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<OrderInvoiceCreateResultModel> OrderResults { get; init; } = Enumerable.Empty<OrderInvoiceCreateResultModel>();

        /// <summary>
        /// Result.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderMultiCreateResult Result { get; init; }
        
        /// <summary>
        /// Failed payments.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<PaymentCreateResultModel> InvalidPayments { get; init; } = Enumerable.Empty<PaymentCreateResultModel>();
    }
}
