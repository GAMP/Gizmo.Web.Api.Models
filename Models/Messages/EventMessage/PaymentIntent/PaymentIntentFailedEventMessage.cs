using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment intent failed event message.
    /// </summary>
    [MessagePackObject()]
    [System.ComponentModel.DataAnnotations.Name("Failed", "PAYMENT_INTENT_FAILED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates payment intent failure", "PAYMENT_INTENT_FAILED_EVENT_DESCRIPTION")]
    public sealed class PaymentIntentFailedEventMessage : PaymentIntentEventMessageBase
    {
    }
}
