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
        /// Gets result.
        /// </summary>
        public OrderPaymentsResult Result { get; init; }

        /// <summary>
        /// Gets invoice id.
        /// </summary>
        /// <remarks>
        /// This will only have value if the payment function succeeded.<br></br>
        /// This will have value of existing or newly created invoice.
        /// </remarks>
        public int? InvoiceId { get; init; }

        /// <summary>
        /// Indicates that new invoice was created.
        /// </summary>
        /// <remarks>
        /// If this value is false then existing invoice where used to execute payments.
        /// </remarks>
        public bool InvoiceCreated { get; init; }

        /// <summary>
        /// Gets invalid payments.
        /// </summary>
        public IEnumerable<PaymentCreateResultModel> FailedPayments { get; init; } = Enumerable.Empty<PaymentCreateResultModel>();

        /// <summary>
        /// Creates new create result model.
        /// </summary>
        /// <param name="result">Result.</param>
        /// <returns>Create result model.</returns>
        public static OrderPaymentsCreateResult Create(OrderPaymentsResult result) => new OrderPaymentsCreateResult { Result = result };

        /// <summary>
        /// Creates new create result model.
        /// </summary>
        /// <param name="failedPayments">Failed payments.</param>
        /// <returns>Create result model.</returns>
        public static OrderPaymentsCreateResult Create(IEnumerable<PaymentCreateResultModel> failedPayments) => new OrderPaymentsCreateResult 
        {
            Result =  OrderPaymentsResult.PaymentsError,
            FailedPayments = failedPayments 
        };
    }
}
