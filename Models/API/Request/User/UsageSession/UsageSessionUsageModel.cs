namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Usage session usage model.
    /// </summary>
    public sealed class UsageSessionUsageModel : IWebApiModel
    {
        /// <summary>
        /// Gets user id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Gets usage id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UsageId { get; init; }

        /// <summary>
        /// Gets usage session id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UsageSessionId { get; init; }        
    }
}
