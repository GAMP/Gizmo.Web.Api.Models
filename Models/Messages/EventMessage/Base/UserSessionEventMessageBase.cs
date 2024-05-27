namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User session event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User session", "USER_SESSION_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User session related events", "USER_SESSION_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(18)]
    public abstract class UserSessionEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId
        {
            get;init;
        }

        /// <summary>
        /// Session id.
        /// </summary>
        [MessagePack.Key(2)]
        public int SessionId
        {
            get;init;
        }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(3)]
        public int HostId
        {
            get;init;
        }

        /// <summary>
        /// Slot.
        /// </summary>
        [MessagePack.Key(4)]
        public int Slot
        {
            get;init;
        }
    }
}
