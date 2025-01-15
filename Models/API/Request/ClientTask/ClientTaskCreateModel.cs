namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client task create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientTaskCreateModel : IWebApiModel
    {
        /// <summary>
        /// Task id.
        /// </summary>
        [MessagePack.Key(0)]
        public int TaskId { get; init; }

        /// <summary>
        /// Activation.
        /// </summary>
        [MessagePack.Key(1)]
        public int Activation {  get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; }
    }
}
