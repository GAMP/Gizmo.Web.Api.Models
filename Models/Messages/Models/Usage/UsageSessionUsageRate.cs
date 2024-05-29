namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Usage rate.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UsageSessionUsageRate : UsageSessionUsage
    {
        /// <summary>
        /// Gets rate id.
        /// </summary>
        [MessagePack.Key(1)]
        public int RateId { get; init; }

        /// <summary>
        /// Gets rate billing profile id.
        /// </summary>
        [MessagePack.Key(2)]
        public int BillingProfileId
        {
            get;init;
        }
    }
}
