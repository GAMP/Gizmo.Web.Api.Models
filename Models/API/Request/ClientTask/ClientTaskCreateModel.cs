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
        /// Whether the task runs at Startup stage.
        /// </summary>
        [MessagePack.Key(1)]
        public bool Startup { get; set; }

        /// <summary>
        /// Whether the task runs at Login stage.
        /// </summary>
        [MessagePack.Key(2)]
        public bool Login { get; set; }

        /// <summary>
        /// Whether the task runs at Logout stage.
        /// </summary>
        [MessagePack.Key(3)]
        public bool Logout { get; set; }

        /// <summary>
        /// Whether the task runs at Shutdown stage.
        /// </summary>
        [MessagePack.Key(4)]
        public bool Shutdown { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        [MessagePack.Key(5)]
        public int UseOrder { get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsEnabled { get; init; }
    }
}
