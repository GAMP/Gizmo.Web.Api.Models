using Gizmo.Server;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Booking options of the club reservations available to the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationOptionsModel : IWebApiModel
    {
        /// <summary>
        /// Minimum reservation duration in minutes; null when not limited.
        /// </summary>
        [Key(0)]
        public int? MinimumTime { get; init; }

        /// <summary>
        /// Maximum reservation duration in minutes; null when not limited.
        /// </summary>
        [Key(1)]
        public int? MaximumTime { get; init; }

        /// <summary>
        /// Whether a reservation of more than one host is disabled.
        /// </summary>
        [Key(2)]
        public bool MultiHostDisable { get; init; }

        /// <summary>
        /// Reservation fee type.
        /// </summary>
        [Key(3)]
        public ReservationFeeType FeeType { get; init; }

        /// <summary>
        /// Reservation fee value (an amount or a percentage, by <see cref="FeeType"/>).
        /// </summary>
        [Key(4)]
        public decimal Fee { get; init; }

        /// <summary>
        /// Minimum payment percentage of the reservation total.
        /// </summary>
        [Key(5)]
        public decimal MinimumPaymentPercentage { get; init; }

        /// <summary>
        /// Cancellation grace period in minutes; null when not set.
        /// </summary>
        [Key(6)]
        public int? CancellationGracePeriod { get; init; }
    }
}
