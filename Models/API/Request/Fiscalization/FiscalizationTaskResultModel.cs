namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization task result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FiscalizationTaskResultModel : IWebApiModel
    {
        /// <summary>
        /// Entity id.
        /// </summary>
        [MessagePack.Key(0)]
        public int EntityId { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [MessagePack.Key(1)]
        public FiscalizationTaskResultStatus Status { get; set; }
    }
}
