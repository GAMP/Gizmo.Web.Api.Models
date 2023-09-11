using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// TODO: Make the description
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeOfferModel
    {
        /// <summary>
        /// Left available minutes of the usage type.
        /// </summary>
        [Key(0)] public int AvailableMinutes { get; set; }

        /// <summary>
        /// Start time of availability the usage type
        /// </summary>
        [Key(1)] public DateTime AvailableTime { get; set; }

        /// <summary>
        /// Expiration time of the usage type. Null if the usage type does not expire.
        /// </summary>
        [Key(2)] public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Id of the InvoiceLine that was used to purchase the usage type.
        /// </summary>
        [Key(3)] public int InvoiceLineId { get; init; }

        /// <summary>
        /// Id of the product that was used to purchase the usage type.
        /// </summary>
        [Key(4)] public int ProductId { get; init; }

        /// <summary>
        /// Purchase date of the product.
        /// </summary>
        [Key(5)] public DateTime PurchaseTime { get; init; }

        /// <summary>
        /// First usage time of the usage type.
        /// </summary>
        [Key(6)] public DateTime? FirstUsageTime { get; init; }

        /// <summary>
        /// Availability of the host.
        /// </summary>
        [Key(7)] public bool IsAvailable { get; init; }
    }
}
