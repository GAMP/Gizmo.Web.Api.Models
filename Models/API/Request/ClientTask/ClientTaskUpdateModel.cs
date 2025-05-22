using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client task update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientTaskUpdateModel : IWebApiModel, IModelIntIdentifier
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
        /// Client task activation type.
        /// </summary>
        [MessagePack.Key(2)]
        public ClientTaskActivationType Activation { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        [MessagePack.Key(3)]
        public int UseOrder { get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsEnabled { get; init; }
    }
}
