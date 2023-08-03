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
        [Key(1)] public string UsageName { get; set; } = null!;
        /// <inheritdoc/>
        [Key(2)] public int AvailableMinutes { get; set; }
        /// <inheritdoc/>
        [Key(3)] public int UsableMinutes { get; set; }
        /// <inheritdoc/>
        [Key(4)] public DateTime UntilTime { get; set; }
        /// <inheritdoc/>
        [Key(5)] public bool IsLogoutExpired { get; set; }
        /// <inheritdoc/>
        [Key(6)] public int? OrderNumber { get; set; }
        /// <inheritdoc/>
        [Key(7)] public bool IsAvailable { get; set; }
        
        /// <summary>
        /// It can be used for time fixed or time offer usage types.
        /// </summary>
        public int? InvoiceLineId { get; set; }
    }
}
