namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User guest released event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserGuestReleasedEventMessage : UserGuestEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGuestReleasedEventMessage() : base()
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
