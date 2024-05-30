namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public abstract class ActiveUsageModel : IWebApiModel
    {
        /// <summary>
        /// Usage session id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UsageSessionId { get; init; }

        /// <summary>
        /// Usage id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? Id { get; set; }
    }
}
