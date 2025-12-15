namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization task model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FiscalizationTaskModel : IWebApiModel
    {
        /// <summary>
        /// Entity id.
        /// </summary>
        [MessagePack.Key(0)]
        public int EntityId { get; set; }

        /// <summary>
        /// Fiscalization task type.
        /// </summary>
        [MessagePack.Key(1)]
        public FiscalizationTaskType Type { get; set; }
    }
}
