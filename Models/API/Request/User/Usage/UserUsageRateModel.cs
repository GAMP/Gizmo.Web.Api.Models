using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageRateModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int? AvailableMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int BillRateId { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool InCredit { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public decimal HourlyRate { get; init; }
    }
}
