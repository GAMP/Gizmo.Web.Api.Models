using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of a reservation booking.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationBookResultModel : IWebApiModel
    {
        /// <summary>
        /// Result.
        /// </summary>
        [Key(0)]
        public UserReservationBookResult Result { get; init; }

        /// <summary>
        /// Id of the created reservation; set only when the result is <see cref="UserReservationBookResult.Success"/>.
        /// </summary>
        [Key(1)]
        public int? ReservationId { get; init; }

        /// <summary>
        /// Hosts that are no longer available.
        /// </summary>
        [Key(2)]
        public IEnumerable<int> UnavailableHostIds { get; init; } = Enumerable.Empty<int>();
    }
}
