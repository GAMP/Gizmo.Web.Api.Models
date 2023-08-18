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
        public int AvailableMinutes { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int InvoiceLineId { get; init; }
    }
}
