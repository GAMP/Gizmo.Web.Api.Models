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
    }
}
