using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time offer usage model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeOfferModel
    {
        /// <summary>
        /// Remaining minutes.
        /// </summary>
        /// <remarks>
        /// Total remaining minutes in usage type.
        /// </remarks>
        [Key(0)] public int RemainingMinutes { get; set; }

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
        /// <remarks>
        /// This value is used in order to give more context on time offer expiration.
        /// </remarks>
        [Key(5)] public DateTime? FirstUsageTime { get; set; }
    }
}
