using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Next host reservation.
    /// </summary>
    [MessagePackObject]
    public sealed class NextHostReservationModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets next reservation id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? NextReservationId { get; set; } = null!;

        /// <summary>
        /// Gets next reservation date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? NextReservationTime { get; set; } = null!;

        /// <summary>
        /// Gets next reservation duration.
        /// </summary>
        [MessagePack.Key(2)]
        public int? NextReservationDuration { get; set; } = null!;

        /// <summary>
        /// Gets next reservation status on this host.
        /// </summary>
        /// <remarks>
        /// <see cref="ReservationHostStatus.Active"/> once a session started on this host inside the reservation window, otherwise <see cref="ReservationHostStatus.Waiting"/>.
        /// </remarks>
        [MessagePack.Key(3)]
        public ReservationHostStatus? NextReservationHostStatus { get; set; }

        /// <summary>
        /// Gets next reservation expiration time.
        /// </summary>
        /// <remarks>
        /// The reservation expires at this time if nobody arrives.<br></br>
        /// Null if the reservation has no expiration or was already activated on any of its hosts.
        /// </remarks>
        [MessagePack.Key(4)]
        public DateTime? NextReservationExpireTime { get; set; }

        #endregion
    }
}
