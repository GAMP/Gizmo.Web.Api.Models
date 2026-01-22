using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User email changed event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserEmailChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEmailChangedEventMessage() : base()
        { }

        /// <summary>
        /// Gets new email value.
        /// </summary>
        [Key(2)]
        public required string? NewEmail
        {
            get;
            init;
        }

        /// <summary>
        /// Gets old email value.
        /// </summary>
        [Key(3)]
        public required string? OldEmail
        {
            get;
            init;
        }
    }
}
