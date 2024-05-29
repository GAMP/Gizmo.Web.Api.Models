namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User usage session event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserUsageSessionUsageChangedEventArgs : UserEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserUsageSessionUsageChangedEventArgs() : base()
        { }

        /// <summary>
        /// Gets usage session id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UsageSessionId
        {
            get; init;
        }

        /// <summary>
        /// Gets current usage.
        /// </summary>
        [MessagePack.Key(2)]
        public UsageSessionUsage CurrentUsage
        {
            get; init;
        } = null!;
    }
}
