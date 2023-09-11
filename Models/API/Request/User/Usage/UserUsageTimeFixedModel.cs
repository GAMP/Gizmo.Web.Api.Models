using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// TODO: Make the description
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeFixedModel
    {
        /// <summary>
        /// Left available minutes of the usage type.
        /// </summary>
        [Key(0)] public int AvailableMinutes { get; set; }

        /// <summary>
        /// Id of the invoice line that was used to purchase the usage type.
        /// </summary>
        [Key(1)] public int InvoiceLineId { get; init; }

        /// <summary>
        /// Purchase date of the usage type.
        /// </summary>
        [Key(2)] public DateTime PurchaseTime { get; init; }

        /// <summary>
        /// Total minutes of the usage type.
        /// </summary>
        [Key(3)] public int TotalMinutes { get; init; }
    }
}
