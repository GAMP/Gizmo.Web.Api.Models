using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Close balance payment state model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CloseBalancePaymentsStateResultModel : IWebApiModel
    {
        /// <summary>
        /// Allowed payment methods.
        /// </summary>
        [MessagePack.Key(0)]
        public required IEnumerable<int> AllowedPaymentMethods { get; init; } = Enumerable.Empty<int>();

        /// <summary>
        /// Indicates if multi payment methods are allowed.
        /// </summary>
        [MessagePack.Key(1)]
        public bool MultiMethodAllowed { get; init; }

        /// <summary>
        /// Gets minimum payment amount.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal MinimumPayment { get; init; }
    }
}
