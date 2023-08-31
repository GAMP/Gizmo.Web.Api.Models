using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeFixedModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Key(0)] public int AvailableMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key(1)] public int InvoiceLineId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [Key(2)] public DateTime PurchaseDate { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [Key(3)] public int TotalMinutes { get; init; }
    }
}
