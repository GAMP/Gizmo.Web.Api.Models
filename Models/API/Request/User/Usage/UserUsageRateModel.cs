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
    }
}
