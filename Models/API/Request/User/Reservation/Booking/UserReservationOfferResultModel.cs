using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of a reservation offer request.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationOfferResultModel : IWebApiModel
    {
        /// <summary>
        /// Result.
        /// </summary>
        [Key(0)]
        public UserReservationOfferResult Result { get; init; }

        /// <summary>
        /// Offer; set only when the result is <see cref="UserReservationOfferResult.Success"/>.
        /// </summary>
        [Key(1)]
        public UserReservationOfferModel? Offer { get; init; }

        /// <summary>
        /// Hosts that are not available or have no price, by the result.
        /// </summary>
        [Key(2)]
        public IEnumerable<int> UnavailableHostIds { get; init; } = Enumerable.Empty<int>();
    }
}
