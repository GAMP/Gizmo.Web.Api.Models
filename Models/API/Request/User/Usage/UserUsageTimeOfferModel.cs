using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeOfferModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Key(0)] public int AvailableMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key(1)] public DateTime AvailableTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key(2)] public DateTime ExpirationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key(3)] public int InvoiceLineId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [Key(4)] public int ProductId { get; init; }
    }
}
