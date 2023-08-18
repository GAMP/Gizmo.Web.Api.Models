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
        public int AvailableMinutes { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime AvailableTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ExpirationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int InvoiceLineId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public int ProductId { get; init; }
    }
}
