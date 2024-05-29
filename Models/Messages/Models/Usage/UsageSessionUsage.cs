namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Usage base.
    /// </summary>
    [MessagePack.Union(0,typeof(UsageSessionUsageRate))]
    [MessagePack.Union(1, typeof(UsageSessionUsageProductTime))]
    [MessagePack.Union(2, typeof(UsageSessionUsageProductTimeFixed))]
    [MessagePack.MessagePackObject()]
    public abstract class UsageSessionUsage
    {
        /// <summary>
        /// Gets usage id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UsageId { get; init; }
    }
}
