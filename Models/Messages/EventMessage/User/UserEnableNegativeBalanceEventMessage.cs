using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User enable negative balance changed event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserEnableNegativeBalanceEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEnableNegativeBalanceEventMessage() : base()
        { }

        /// <summary>
        /// Gets if negative balance allowed for user.
        /// </summary>
        [Key(2)]
        public bool? Enabled
        {
            get; init;
        }
    }
}
