using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent declined event message.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Declined", "PAYMENT_INTENT_DECLINED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent decline", "PAYMENT_INTENT_DECLINED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentDeclinedEventMessage : PaymentIntentEventMessageBase
    {        
    }
}
