using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{ 
    /// <summary>
    /// Close balance model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CloseBalanceCreateModel : IWebApiModel
    {
        /// <summary>
        /// Payments.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentCreateModel> Payments { get; init; } = Enumerable.Empty<PaymentCreateModel>();

        /// <summary>
        /// Specific invoices to be closed.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<int> Invoices { get; init; } = Enumerable.Empty<int>();

        /// <summary>
        /// Disables receipt printing.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DisableReceiptPrinting { get; set; }
    }
}
