using Gizmo.Web.Api.Messaging;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.Messages.EventMessage.PaymentIntent
{
    /// <summary>
    /// Payment intent expiration event message.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Expired", "PAYMENT_INTENT_EXPIRED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent expired", "PAYMENT_INTENT_EXPIRED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentExpiredEventMessage : PaymentIntentEventMessageBase
    {
    }
}
