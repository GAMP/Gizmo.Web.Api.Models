using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Roadmap of the user's spending resources.
    /// </summary>
    public interface IUserUsageTimeLevelModel : IWebApiModel
    {
        /// <summary>
        /// Just a users money.
        /// </summary>
        UserUsageRateModel? Rate { get; init; }

        /// <summary>
        /// Complex product.
        /// </summary>
        UserUsageTimeOfferModel? TimeOffer { get; init; }

        /// <summary>
        /// Just a time.
        /// </summary>
        UserUsageTimeFixedModel? TimeFixed { get; init; }

        /// <summary>
        /// Current available usage type.
        /// </summary>
        UsageType UsageType { get; init; }

        /// <summary>
        /// Available minutes till the next step of the roadmap. Null is the last step.
        /// </summary>
        int? AvailableMinutes { get; init; }

        /// <summary>
        /// Start time of the roadmap step.
        /// </summary>
        DateTime AvailableTime { get; set; }

        /// <summary>
        /// The number of a step for the roadmap. Null if the roadmap has a gap.
        /// </summary>
        int? ActivationOrder { get; set; }
    }
}
