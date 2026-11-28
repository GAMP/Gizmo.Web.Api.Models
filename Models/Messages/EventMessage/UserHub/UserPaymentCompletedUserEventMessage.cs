using System;
using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User payment completed event message. Sent to the owner of the payment.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserPaymentCompletedUserEventMessage : UserEventMessage
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPaymentCompletedUserEventMessage() : base()
        { }

        /// <summary>
        /// Gets payment intent id.
        /// </summary>
        [Key(1)]
        public Guid Intent
        {
            get; init;
        }
    }
}
