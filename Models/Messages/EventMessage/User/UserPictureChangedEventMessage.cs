using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User picture changed event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserPictureChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPictureChangedEventMessage() : base()
        { }
    }
}
