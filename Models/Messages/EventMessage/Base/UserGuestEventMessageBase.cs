using Gizmo.Web.Api.Messaging;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User guest event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User guest", "USER_GUEST_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User guest related events", "USER_GUEST_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(23)]
    public abstract class UserGuestEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public UserGuestEventMessageBase()
        { }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; init; }
    }
}
