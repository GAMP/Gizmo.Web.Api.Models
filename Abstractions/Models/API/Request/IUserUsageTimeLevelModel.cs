using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserUsageTimeLevelModel : IWebApiModel
    {
        /// <summary>
        /// 
        /// </summary>
        UserUsageRateModel? Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        UserUsageTimeOfferModel? TimeOffer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        UserUsageTimeFixedModel? TimeFixed { get; set; }

        /// <summary>
        /// Available usage type.
        /// </summary>
        UsageType CurrentUsageType { get; init; }

        /// <summary>
        /// 
        /// </summary>
        int UsageTypeId { get; set; }

        /// <summary>
        /// Name of the usage type.
        /// </summary>
        string UsageName { get; init; }

        /// <summary>
        /// Sum of all usage minutes.
        /// </summary>
        int AvailableMinutes { get; init; }

        /// <summary>
        /// Sum of all usage minutes in the current session.
        /// </summary>
        int UsableMinutes { get; set; }

        /// <summary>
        /// Time when the usage type would be expired in the current session.
        /// </summary>
        DateTime UntilTime { get; set; }

        /// <summary>
        /// Number of the order for the usage types roadmap.
        /// </summary>
        int? OrderNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool ExpiresAtLogout { get; init; }

        /// <summary>
        /// Available or not in the current session.
        /// </summary>
        bool IsAvailable { get; set; }
    }
}
