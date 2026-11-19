using System;
using Gizmo.Web.Api.Models;
using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User payment failed event message: the payment is failed, declined, expired or cancelled. Sent to the owner of the payment.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserPaymentFailedUserEventMessage : UserEventMessage
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPaymentFailedUserEventMessage() : base()
        { }

        /// <summary>
        /// Gets payment intent id.
        /// </summary>
        [Key(1)]
        public Guid Intent
        {
            get; init;
        }

        /// <summary>
        /// Gets payment intent state.
        /// </summary>
        [Key(2)]
        public PaymentIntentState State
        {
            get; init;
        }
    }
}
