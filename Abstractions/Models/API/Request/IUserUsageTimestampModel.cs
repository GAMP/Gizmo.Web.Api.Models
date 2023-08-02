namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserUsageTimestampModel : IWebApiModel
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
        /// 
        /// </summary>
        public UsageType CurrentUsageType { get; init; }
    }
}
