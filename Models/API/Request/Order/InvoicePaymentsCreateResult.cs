using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models 
{
    /// <summary>
    /// Invoice payment creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoicePaymentsCreateResult : IWebApiModel
    {
        /// <summary>
        /// Invalid payments.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentCreateResultModel> InvalidPayments { get;  init; } = Enumerable.Empty<PaymentCreateResultModel>();
    }
}
