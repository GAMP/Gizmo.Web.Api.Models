using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payments result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoicePaymentsCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Created payments.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<AcceptedOrderPaymentModel> Payments { get; set; } = Enumerable.Empty<AcceptedOrderPaymentModel>();

        /// <summary>
        /// Optional expected payment model.
        /// </summary>
        [MessagePack.Key(1)]
        public ExpectedOrderPaymentModel? ExpectedPayment
        {
            get; init;
        }
    }
}
