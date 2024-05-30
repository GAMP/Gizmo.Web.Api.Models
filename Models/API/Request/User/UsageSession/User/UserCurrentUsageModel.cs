namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User current usage model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserCurrentUsageModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Gets current usage.
        /// </summary>
        [MessagePack.Key(1)]
        public UsageModel Usage { get; init; } = null!;
    }
}
