using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment status filter for reservations.
    /// </summary>
    [Flags()]
    public enum ReservationPaymentStatusFilter
    {
        /// <summary>
        /// No order or payment is required—user can use the reservation “as is.”
        /// </summary>
        NotRequired = 1,

        /// <summary>
        /// Pre-payment threshold has NOT been reached yet.
        /// </summary>
        NotSatisfied = 2,

        /// <summary>
        /// Threshold reached but the reservation is not fully paid yet.
        /// </summary>
        PartiallySatisfied = 4,

        /// <summary>
        /// Pre-payment threshold has been reached and reservation is fully paid.
        /// </summary>
        Satisfied = 8
    }
}
