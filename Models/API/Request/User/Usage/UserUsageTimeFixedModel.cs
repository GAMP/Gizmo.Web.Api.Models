using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time fixed usage model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeFixedModel
    {
        /// <summary>
        /// Remaining minutes.
        /// </summary>
        /// <remarks>
        /// Total remaining minutes in usage type.
        /// </remarks>
        [Key(0)] public int RemainingMinutes { get; set; }

        /// <summary>
        /// Id of the invoice line that was used to purchase the usage type.
        /// </summary>
        [Key(1)] public int InvoiceLineId { get; init; }

        /// <summary>
        /// Purchase date of the usage type.
        /// </summary>
        [Key(2)] public DateTime PurchaseTime { get; set; }

        /// <summary>
        /// Total minutes of the usage type.
        /// </summary>
        /// <remarks>
        /// Only set in timed fixed product in order to show the total amount in UI.
        /// </remarks>
        [Key(3)] public int TotalMinutes { get; init; }
    }
}
