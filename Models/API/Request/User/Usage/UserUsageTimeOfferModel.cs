using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeOfferModel : IUserUsageTypeModel
    {
        /// <inheritdoc/>
        public int UsageTypeId { get; init; }
        /// <inheritdoc/>
        public int AvailableMinutes { get; init; }
        /// <inheritdoc/>
        public int UsableMinutes { get; init; }
        /// <inheritdoc/>
        public DateTime UntilTime { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        public int InvoiceLineId { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; init; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExpiresAtLogout { get; init; }
    }
}
