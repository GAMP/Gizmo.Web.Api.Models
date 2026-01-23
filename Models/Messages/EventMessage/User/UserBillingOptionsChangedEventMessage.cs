using Gizmo.Web.Api.Models;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User billing options change event.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserBillingOptionsChangedEventMessage : UserEventMessageBase
    {
        /// <summary>
        /// Current options.
        /// </summary>
        [MessagePack.Key(2)]
        public BillingOption? Options { get;init; }
    }
}
