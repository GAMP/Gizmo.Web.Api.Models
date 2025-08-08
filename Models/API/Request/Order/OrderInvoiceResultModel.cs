using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order invoicing result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoiceResultModel : IWebApiModel
    {
        /// <summary>
        /// Gets result.
        /// </summary>
        [MessagePack.Key(0)]
        public OrderInvoiceResult Result { get; init; }

        /// <summary>
        /// Gets invoice id.
        /// </summary>
        /// <remarks>
        /// This will only have value if the payment function succeeded.<br></br>
        /// </remarks>
        [MessagePack.Key(1)]
        public int? InvoiceId { get; init; }


        /// <summary>
        /// Gets invalid payments.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<PaymentCreateResultModel> InvalidPayments { get; init; } = Enumerable.Empty<PaymentCreateResultModel>();

        /// <summary>
        /// Creates new create result model.
        /// </summary>
        /// <param name="result">Result.</param>
        /// <returns>Create result model.</returns>
        public static OrderInvoiceResultModel Create(OrderInvoiceResult result) => new() { Result = result };

        /// <summary>
        /// Creates new create result model.
        /// </summary>
        /// <param name="invalidOrFailedPayments">Failed payments.</param>
        /// <returns>Create result model.</returns>
        public static OrderInvoiceResultModel Create(IEnumerable<PaymentCreateResultModel> invalidOrFailedPayments) => new()
        {
            Result = OrderInvoiceResult.InvalidPayments,
            InvalidPayments = invalidOrFailedPayments
        };
    }
}
