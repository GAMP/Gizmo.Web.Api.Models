namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User usage session event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserUsageSessionUsageChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserUsageSessionUsageChangedEventMessage() : base()
        { }

        /// <summary>
        /// Gets usage session id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UsageSessionId
        {
            get; init;
        }

        /// <summary>
        /// Gets current usage.
        /// </summary>
        [MessagePack.Key(3)]
        public UsageSessionUsage CurrentUsage
        {
            get; init;
        } = null!;
    }
}
