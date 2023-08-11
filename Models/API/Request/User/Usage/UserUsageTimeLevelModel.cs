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
            UsageType = UsageType.None;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public UserUsageTimeLevelModel(UserUsageRateModel model)
        {
            Rate = model;
            UsageType = UsageType.Rate;
            
            IsAvailable = model.IsAvailable;
            ActivationTime = model.ActivationTime;
            AvailableMinutes = model.AvailableMinutes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public UserUsageTimeLevelModel(UserUsageTimeOfferModel model)
        {
            TimeOffer = model;
            UsageType = UsageType.TimeOffer;
            
            IsAvailable = model.IsAvailable;
            ActivationTime = model.ActivationTime;
            AvailableMinutes = model.AvailableMinutes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public UserUsageTimeLevelModel(UserUsageTimeFixedModel model)
        {
            TimeFixed = model;
            UsageType = UsageType.TimeFixed;
            
            IsAvailable = model.IsAvailable;
            AvailableMinutes = model.AvailableMinutes;
            ActivationTime = model.ActivationTime;
        }

        #endregion

        /// <inheritdoc/>
        public UserUsageRateModel? Rate { get; init; }

        /// <inheritdoc/>
        public UserUsageTimeOfferModel? TimeOffer { get; init; }

        /// <inheritdoc/>>
        public UserUsageTimeFixedModel? TimeFixed { get; init; }

        /// <inheritdoc/>
        public UsageType UsageType { get; init; }

        /// <inheritdoc/>
        public bool IsAvailable { get; init; }
        
        /// <inheritdoc/>
        public int AvailableMinutes { get; init; }
        
        /// <inheritdoc/>
        public DateTime? ActivationTime { get; init; }
        
        /// <inheritdoc/>
        public int? ActivationOrder { get; set; }
    }
}
