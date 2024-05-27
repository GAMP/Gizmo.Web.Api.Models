using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User session moved event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("State changed", "USER_SESSION_STATE_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User session state changed", "USER_SESSION_STATE_CHANGED_GROUP_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class UserSessionStateChangedEventMessage : UserSessionEventMessageBase
    {
        /// <summary>
        /// New session state.
        /// </summary>
        [MessagePack.Key(5)]
        public SessionState State
        {
            get;init;
        }
    }
}
