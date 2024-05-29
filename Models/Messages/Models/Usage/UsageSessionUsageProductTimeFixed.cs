namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Usage time fixed.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageSessionUsageProductTimeFixed : UsageSessionUsage
    {
        /// <summary>
        /// Gets product time id.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductTimeFixedPurchaseId
        {
            get;init;
        }
    }
}
