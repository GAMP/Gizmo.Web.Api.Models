using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent captured event message.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Captured", "PAYMENT_INTENT_CAPTURED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent capture", "PAYMENT_INTENT_CAPTURED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentCapturedEventMessage : PaymentIntentEventMessageBase
    {        
    }
}
