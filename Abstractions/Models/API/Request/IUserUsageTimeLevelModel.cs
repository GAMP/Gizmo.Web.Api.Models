using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Roadmap of the user's spending resources.
    /// </summary>
    public interface IUserUsageTimeLevelModel : IWebApiModel
    {
        /// <summary>
        /// Rate model.
        /// </summary>
        UserUsageRateModel? Rate { get; init; }

        /// <summary>
        /// Time offer model.
        /// </summary>
        UserUsageTimeOfferModel? TimeOffer { get; init; }

        /// <summary>
        /// Time fixed model.
        /// </summary>
        UserUsageTimeFixedModel? TimeFixed { get; init; }

        /// <summary>
        /// Current usage type.
        /// </summary>
        UsageType UsageType { get; init; }

        /// <summary>
        /// Usable minutes in current usage.
        /// </summary>
        /// <remarks>
        /// This will indicate maximum amount of minutes that can be used in current usage.<br></br>
        /// This value can be equal to null only in case of rate and will indicate unlimited time.
        /// </remarks>
        int? UsableMinutes { get; init; }

        /// <summary>
        /// Activation time of usage within current usage session.
        /// </summary>
        DateTime? ActivationTime { get; set; }

        /// <summary>
        /// Activation order within current usage session.
        /// </summary>
        /// <remarks>
        /// The value will be null if product was used in part or not at all within current usage session.
        /// </remarks>
        int? ActivationOrder { get; set; }
    }
}
