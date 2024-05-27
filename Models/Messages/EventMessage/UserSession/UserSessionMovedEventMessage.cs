namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User session moved event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Moved", "USER_SESSION_MOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User session moved", "USER_SESSION_MOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class UserSessionMovedEventMessage : UserSessionEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSessionMovedEventMessage() : base()
        { }
    }
}
