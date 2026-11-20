using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Options of the online balance top up.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPaymentOptionsModel : IWebApiModel
    {
        /// <summary>
        /// Top up presets in the display order.
        /// </summary>
        [Key(0)]
        public IEnumerable<decimal> Presets { get; init; } = Enumerable.Empty<decimal>();

        /// <summary>
        /// Whether the user can enter a custom top up amount.
        /// </summary>
        [Key(1)]
        public bool IsCustomValueAllowed { get; init; }

        /// <summary>
        /// Minimum custom top up amount.
        /// </summary>
        [Key(2)]
        public decimal? MinimumValue { get; init; }

        /// <summary>
        /// Maximum custom top up amount.
        /// </summary>
        [Key(3)]
        public decimal? MaximumValue { get; init; }

        /// <summary>
        /// Enabled online payment methods in the display order.
        /// </summary>
        [Key(4)]
        public IEnumerable<UserOnlinePaymentMethodModel> PaymentMethods { get; init; } = Enumerable.Empty<UserOnlinePaymentMethodModel>();
    }
}
