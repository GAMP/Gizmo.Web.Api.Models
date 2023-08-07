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
        /// Identifier of the bill rate.
        /// </summary>
        [Key(0)] public int BillRateId { get; set; }
        
        /// <summary>
        /// Name of the bill rate profile.
        /// </summary>
        [Key(1)] public string Name { get; set; } = null!;

        /// <summary>
        /// Sum of the bill rate.
        /// </summary>
        [Key(2)]public int AvailableMinutes { get; set; }
    }
}
