using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation of the current user as seen by the user app.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserReservationModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// Reservation id.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Reservation start (UTC).
        /// </summary>
        [Key(1)]
        [Sortable]
        public DateTime Date { get; init; }

        /// <summary>
        /// Reservation start in the wall-clock time of the club.
        /// </summary>
        [Key(2)]
        public DateTime BranchDate { get; init; }

        /// <summary>
        /// Duration in minutes.
        /// </summary>
        [Key(3)]
        public int Duration { get; init; }

        /// <summary>
        /// Reservation status.
        /// </summary>
        [Key(4)]
        public ReservationStatus Status { get; init; }

        /// <summary>
        /// Branch (club) id.
        /// </summary>
        [Key(5)]
        public int BranchId { get; init; }

        /// <summary>
        /// Branch (club) name.
        /// </summary>
        [Key(6)]
        public string BranchName { get; init; } = string.Empty;

        /// <summary>
        /// Branch (club) address.
        /// </summary>
        [Key(7)]
        public string? BranchAddress { get; init; }

        /// <summary>
        /// Whether the current user is the owner of the reservation (otherwise a member).
        /// </summary>
        [Key(8)]
        public bool IsOwner { get; init; }

        /// <summary>
        /// Reservation PIN.
        /// </summary>
        [Key(9)]
        public string? Pin { get; init; }

        /// <summary>
        /// Reservation payment status.
        /// </summary>
        [Key(10)]
        public ReservationPaymentStatus PaymentStatus { get; init; }

        /// <summary>
        /// Total of the non-voided invoices of the reservation.
        /// </summary>
        [Key(11)]
        public decimal Total { get; init; }

        /// <summary>
        /// Outstanding amount of the non-voided invoices of the reservation.
        /// </summary>
        [Key(12)]
        public decimal Outstanding { get; init; }

        /// <summary>
        /// Cancellation grace period in minutes. The refund cutoff is the start minus this value, or the start when null.
        /// </summary>
        [Key(13)]
        public int? CancellationGracePeriod { get; init; }

        /// <summary>
        /// Hosts of the reservation, moved-away hosts excluded.
        /// </summary>
        [Key(14)]
        public IEnumerable<UserReservationHostModel> Hosts { get; init; } = Enumerable.Empty<UserReservationHostModel>();
    }
}
