using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeLevelModel : IUserUsageTimeLevelModel
    {
        /// <inheritdoc/>
        [Key(0)] public UserUsageRateModel? Rate { get; init; }

        /// <inheritdoc/>
        [Key(1)] public UserUsageTimeOfferModel? TimeOffer { get; init; }

        /// <inheritdoc/>>
        [Key(2)] public UserUsageTimeFixedModel? TimeFixed { get; init; }

        /// <inheritdoc/>
        [Key(3)] public UsageType UsageType { get; init; }

        /// <inheritdoc/>
        [Key(4)] public int? AvailableMinutes { get; init; }
        
        /// <inheritdoc/>
        [Key(5)]public DateTime AvailableTime { get; set; }
        
        /// <inheritdoc/>
        [Key(6)] public int? ActivationOrder { get; set; }
    }
}
