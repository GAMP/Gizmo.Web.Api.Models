namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User negative balance enabled event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserNegativeBalanceEnabledMessage : UserEventMessageBase
    {
        /// <summary>
        /// Indicates if negative balance is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsEnabled { get; init; }
    }
}
