using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User smart card change event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserSmartCardChangeEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSmartCardChangeEventMessage() : base()
        { }
    }
}
