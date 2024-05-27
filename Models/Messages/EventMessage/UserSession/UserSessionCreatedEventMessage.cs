using Gizmo.Web.Api.Models.Enumerations;

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

        /// <summary>
        /// Initial session state.
        /// </summary>
        [MessagePack.Key(5)]
        public SessionState State
        {
            get; init;
        }
    }
}
