using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client task model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientTaskModel : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Task id.
        /// </summary>
        [MessagePack.Key(1)]
        public int TaskId { get; init; }

        /// <summary>
        /// Activation.
        /// </summary>
        [MessagePack.Key(2)]
        public int Activation {  get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsEnabled { get; init; }

        /// <summary>
        /// Use order.
        /// </summary>
        [MessagePack.Key(4)]
        public int UserOrder {  get; init; }
    }
}
