using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payments allowed model.
    /// </summary>
    /// <remarks>
    /// Represents a request model for checking allowed payment methods.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentsAllowedModel : IWebApiModel
    {
        /// <summary>
        /// Allowed payment methods.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<int> AllowedPaymentMethods { get; init; } = Enumerable.Empty<int>();

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
