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
        [Key(0)] public int? AvailableMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Key(1)] public int BillRateId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [Key(2)] public bool InCredit { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [Key(3)] public decimal HourlyRate { get; init; }
    }
}
