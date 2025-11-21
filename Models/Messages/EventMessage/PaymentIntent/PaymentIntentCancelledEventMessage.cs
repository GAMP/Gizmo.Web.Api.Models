using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent captured event message.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Cancelled", "PAYMENT_INTENT_CANCELLED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent cancellation", "PAYMENT_INTENT_CANCELLED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentCancelledEventMessage : PaymentIntentEventMessageBase
    {        
    }
}
