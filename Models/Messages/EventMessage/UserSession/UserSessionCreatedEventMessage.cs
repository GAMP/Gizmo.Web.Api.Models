namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User session created event.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Created", "USER_SESSION_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User session created", "USER_SESSION_CREATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class UserSessionCreatedEventMessage : UserSessionEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSessionCreatedEventMessage()
        { }
    }
}
