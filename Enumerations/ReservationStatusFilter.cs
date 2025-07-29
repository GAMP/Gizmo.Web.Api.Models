using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Status filter for reservations.
    /// </summary>
    /// <remarks>
    /// The purpose is to allow including multiple reservation statuses in a single filter.
    /// </remarks>
    [Flags()]
    public enum ReservationStatusFilter
    {
        /// <summary>
        /// Waiting for reservation.
        /// </summary>
        Waiting = 1,
        
        /// <summary>
        /// Active reservation.
        /// </summary>
        Active = 2,
        
        /// <summary>
        /// Cancelled reservation.
        /// </summary>
        Cancelled = 4,
        
        /// <summary>
        /// Expired reservation.
        /// </summary>
        Expired = 8,
        
        /// <summary>
        /// Competed reservation.
        /// </summary>
        Completed = 16,

        /// <summary>
        /// Released reservation.
        /// </summary>
        Released = 32,
    }
}
