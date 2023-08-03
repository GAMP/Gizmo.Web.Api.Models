using System;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeLevelModel : IUserUsageTimeLevelModel
    {
        #region CONSTRUCTOR

        /// <summary>
        /// 
        /// </summary>
        public UserUsageTimeLevelModel() => CurrentUsageType = UsageType.None;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rate"></param>
        public UserUsageTimeLevelModel(UserUsageRateModel rate)
        {
            Rate = rate;
            CurrentUsageType = UsageType.Rate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeOffer"></param>
        public UserUsageTimeLevelModel(UserUsageTimeOfferModel timeOffer)
        {
            TimeOffer = timeOffer;
            CurrentUsageType = UsageType.TimeOffer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeFixed"></param>
        public UserUsageTimeLevelModel(UserUsageTimeFixedModel timeFixed)
        {
            TimeFixed = timeFixed;
            CurrentUsageType = UsageType.TimeFixed;
        }

        #endregion

        /// <inheritdoc/>
        [Key(0)] public UserUsageRateModel? Rate { get; set; }

        /// <inheritdoc/>
        [Key(1)] public UserUsageTimeOfferModel? TimeOffer { get; set; }

        /// <inheritdoc/>>
        [Key(2)] public UserUsageTimeFixedModel? TimeFixed { get; set; }

        /// <inheritdoc/>
        [Key(3)] public UsageType CurrentUsageType { get; init; }

        /// <inheritdoc/>
        [Key(4)] public int UsageTypeId { get; set; }
        /// <inheritdoc/>
        [Key(5)] public string UsageName { get; set; } = null!;
        /// <inheritdoc/>
        [Key(6)] public int AvailableMinutes { get; set; }
        /// <inheritdoc/>
        [Key(7)] public int UsableMinutes { get; set; }
        /// <inheritdoc/>
        [Key(8)] public DateTime UntilTime { get; set; }
        /// <inheritdoc/>
        [Key(9)] public int? OrderNumber { get; set; }
        /// <inheritdoc/>
        [Key(10)] public bool IsLogoutExpired { get; set; }
        /// <inheritdoc/>
        [Key(11)] public bool IsAvailable { get; set; }
    }
}
