namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User guest reserved event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserGuestReservedEventMessage : UserGuestEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGuestReservedEventMessage() : base()
        { }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? HostId { get; init; }

        /// <summary>
        /// Slot id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? Slot { get; init; }
    }
}
