using System;
using System.ComponentModel.DataAnnotations;

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
        [Name("On Hold", "ORDER_STATUS_FILTER_ON_HOLD")]
        OnHold = 1,

        /// <summary>
        /// Completed.
        /// </summary>
        [Name("Completed", "ORDER_STATUS_FILTER_COMPLETED")]
        Completed = 2,

        /// <summary>
        /// Canceled.
        /// </summary>
        [Name("Canceled", "ORDER_STATUS_FILTER_CANCELED")]
        Canceled = 4,

        /// <summary>
        /// Accepted.
        /// </summary>
        [Name("Accepted", "ORDER_STATUS_FILTER_ACCEPTED")]
        Accepted = 8,

        /// <summary>
        /// Processing.
        /// </summary>
        [Name("Processing", "ORDER_STATUS_FILTER_PROCESSING")]
        Processing = 16,
    }
}
