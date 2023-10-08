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
        /// Expiration time of the usage type. Null if the usage type does not expire.
        /// </summary>
        [Key(1)] public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Id of the InvoiceLine that was used to purchase the usage type.
        /// </summary>
        [Key(2)] public int InvoiceLineId { get; init; }

        /// <summary>
        /// Id of the product that was used to purchase the usage type.
        /// </summary>
        [Key(3)] public int ProductId { get; init; }

        /// <summary>
        /// Purchase date of the product.
        /// </summary>
        [Key(4)] public DateTime PurchaseTime { get; set; }

        /// <summary>
        /// First usage time of the usage type.
        /// </summary>
        [Key(5)] public DateTime? FirstUsageTime { get; set; }
    }
}
