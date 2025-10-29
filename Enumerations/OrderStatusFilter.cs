using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment status filter for orders.
    /// </summary>
    [Flags()]
    public enum OrderStatusFilter
    {

        /// <summary>
        /// On hold.
        /// </summary>
        OnHold = 1,

        /// <summary>
        /// Completed.
        /// </summary>
        Completed = 2,

        /// <summary>
        /// Canceled.
        /// </summary>
        Canceled = 4,

        /// <summary>
        /// Accepted.
        /// </summary>
        Accepted = 8,

        /// <summary>
        /// Processing.
        /// </summary>
        Processing = 16,
    }
}
