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
        /// Whether the task runs at Startup stage.
        /// </summary>
        [MessagePack.Key(2)]
        public bool Startup { get; set; }

        /// <summary>
        /// Whether the task runs at Login stage.
        /// </summary>
        [MessagePack.Key(3)]
        public bool Login { get; set; }

        /// <summary>
        /// Whether the task runs at Logout stage.
        /// </summary>
        [MessagePack.Key(4)]
        public bool Logout { get; set; }

        /// <summary>
        /// Whether the task runs at Shutdown stage.
        /// </summary>
        [MessagePack.Key(5)]
        public bool Shutdown { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        [MessagePack.Key(6)]
        public int UseOrder {  get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsEnabled { get; init; }

    }
}
