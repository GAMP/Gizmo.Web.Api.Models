using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// News changed event message. Carries no values, the app reads the news through the user API.
    /// </summary>
    [MessagePackObject()]
    public sealed class NewsChangedUserEventMessage : UserEventMessage
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public NewsChangedUserEventMessage() : base()
        { }
    }
}
