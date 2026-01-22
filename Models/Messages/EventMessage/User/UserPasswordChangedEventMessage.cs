using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User password changed event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserPasswordChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPasswordChangedEventMessage() : base()
        { }
    }
}
