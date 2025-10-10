using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order payments parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderPaymentsCreateModel : IWebApiModel
    {
        /// <summary>
        /// Payments to create.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentCreateModel> Payments { get; init; } = Enumerable.Empty<PaymentCreateModel>();

        /// <summary>
        /// Disables receipt printing.
        /// </summary>
        [MessagePack.Key(1)]
        public bool DisableReceiptPrinting { get; set; }
    }
}
