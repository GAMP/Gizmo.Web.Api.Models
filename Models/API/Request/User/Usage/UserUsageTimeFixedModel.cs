using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeFixedModel : IUserUsageTypeModel
    {
        /// <inheritdoc/>
        [Key(0)] public int UsageTypeId { get; set; }
        /// <inheritdoc/>
        [Key(1)] public DateTime StartTime { get; set; }
        /// <inheritdoc/>
        [Key(2)] public DateTime EndTime { get; set; }
        /// <inheritdoc/>
        [Key(3)] public int? OrderNumber { get; set; }
        /// <inheritdoc/>
        [Key(4)] public bool IsAvailable { get; set; }
    }
}
