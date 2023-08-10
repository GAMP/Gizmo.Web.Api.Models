namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserUsageTimeLevelModel : IUserUsageTypeModel, IWebApiModel
    {
        /// <summary>
        /// 
        /// </summary>
        UserUsageRateModel? Rate { get; init; }

        /// <summary>
        /// 
        /// </summary>
        UserUsageTimeOfferModel? TimeOffer { get; init; }

        /// <summary>
        /// 
        /// </summary>
        UserUsageTimeFixedModel? TimeFixed { get; init; }

        /// <summary>
        /// Available usage type.
        /// </summary>
        UsageType CurrentUsageType { get; init; }

        /// <summary>
        /// Number of the order for the usage types roadmap.
        /// </summary>
        int? ActivationOrder { get; set; }
    }
}
