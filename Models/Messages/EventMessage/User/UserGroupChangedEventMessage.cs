using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User group changed event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserGroupChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGroupChangedEventMessage() : base()
        { }

        /// <summary>
        /// Gets new user group id.
        /// </summary>
        [Key(2)]
        public required int NewUserGroupId
        {
            get; init;
        }

        /// <summary>
        /// Gets old user group id.
        /// </summary>
        [Key(3)]
        public required int OldUserGroupId
        {
            get; init;
        }
    }
}
