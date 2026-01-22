using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance close event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserBalanceCloseEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceCloseEventMessage() : base()
        { }
    }
}
