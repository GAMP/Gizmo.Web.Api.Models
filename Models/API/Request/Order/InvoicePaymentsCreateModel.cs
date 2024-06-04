using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payments creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoicePaymentsCreateModel
    {
        /// <summary>
        /// Invoice payments.
        /// </summary>
        /// <remarks>
        /// Invoice payments to be created on invoice.
        /// </remarks>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentCreateModel> Payments { get; init; } = Enumerable.Empty<PaymentCreateModel>();
    }
}
