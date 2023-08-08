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
        public UserUsageTimeLevelModel()
        {
            CurrentUsageType = UsageType.None;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public UserUsageTimeLevelModel(UserUsageRateModel model)
        {
            Rate = model;
            UsageTypeId = model.UsageTypeId;
            CurrentUsageType = UsageType.Rate;
            AvailableMinutes = model.AvailableMinutes;
            UsableMinutes = model.UsableMinutes;
            UntilTime = model.UntilTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public UserUsageTimeLevelModel(UserUsageTimeOfferModel model)
        {
            TimeOffer = model;
            UsageTypeId = model.UsageTypeId;
            CurrentUsageType = UsageType.TimeOffer;
            AvailableMinutes = model.AvailableMinutes;
            ExpiresAtLogout = model.ExpiresAtLogout;
            UsableMinutes = model.UsableMinutes;
            UntilTime = model.UntilTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public UserUsageTimeLevelModel(UserUsageTimeFixedModel model)
        {
            TimeFixed = model;
            UsageTypeId = model.UsageTypeId;
            CurrentUsageType = UsageType.TimeFixed;
            AvailableMinutes = model.AvailableMinutes;
            UsableMinutes = model.UsableMinutes;
            UntilTime = model.UntilTime;
        }

        #endregion

        /// <inheritdoc/>
        public UserUsageRateModel? Rate { get; init; }

        /// <inheritdoc/>
        public UserUsageTimeOfferModel? TimeOffer { get; init; }

        /// <inheritdoc/>>
        public UserUsageTimeFixedModel? TimeFixed { get; init; }

        /// <inheritdoc/>
        public UsageType CurrentUsageType { get; init; }

        /// <inheritdoc/>
        public int UsageTypeId { get; init; }

        /// <inheritdoc/>
        public int AvailableMinutes { get; init; }
        /// <inheritdoc/>
        public int UsableMinutes { get; init; }
        /// <inheritdoc/>
        public DateTime UntilTime { get; init; }
        /// <inheritdoc/>
        public bool ExpiresAtLogout { get; init; }
        
        /// <inheritdoc/>
        public int? OrderNumber { get; set; }
        /// <inheritdoc/>
        public bool IsAvailable { get; set; }
    }
}
