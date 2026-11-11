using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance changed event message. Carries no values, the app reads the balance through the user API.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserBalanceChangedUserEventMessage : UserEventMessage
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceChangedUserEventMessage() : base()
        { }
    }
}
