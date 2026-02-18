using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client next reservation model.
    /// </summary>
    public interface IClientNextReservationModel : IWebApiModel
    {
        /// <summary>
        /// Gets next reservation id.
        /// </summary>
        /// <remarks>
        /// The value will be null if there are no upcoming reservations.
        /// </remarks>
        public int? NextReservationId { get; init; }

        /// <summary>
        /// Gets next reservation date.
        /// </summary>
        /// <remarks>
        /// Will be null if there are no upcoming reservations. Otherwise, it will contain the date and time of the next reservation. This can be used to determine when the next reservation is scheduled to start.
        /// </remarks>
        public DateTime? NextReservationTime { get; init; }

        /// <summary>
        /// Reservation duration in minutes.
        /// </summary>
        /// <remarks>
        /// This can be used to determine how long the reservation is scheduled to last. The value will be null if there are no upcoming reservations or if the duration is not specified for the reservation.
        /// </remarks>
        public int? Duration { get; init; }

        /// <summary>
        /// Time in minutes before upcoming reservation to block login.
        /// </summary>
        /// <remarks>
        /// This can be used to determine when we will start blocking non-reservation users from logging in. The value will be null if there are no upcoming reservations or login blocking is disabled.
        /// </remarks>
        public int? LoginBlockBeforeTime { get; init; }
    }
}
