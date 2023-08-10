using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageRateModel : IUserUsageTypeModel
    {
        /// <inheritdoc/>
        public int AvailableMinutes { get; init; }
        
        /// <inheritdoc/>
        public bool IsAvailable { get; init; }
        /// <inheritdoc/>
        public DateTime? ActivationTime { get; init; }

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
