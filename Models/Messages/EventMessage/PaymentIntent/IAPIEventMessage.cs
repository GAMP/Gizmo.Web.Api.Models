using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(700, typeof(PaymentIntentCreatedEventMessage))]
    [Union(701, typeof(PaymentIntentCompletedEventMessage))]
    [Union(702, typeof(PaymentIntentCapturedEventMessage))]
    [Union(703, typeof(PaymentIntentDeclinedEventMessage))]
    [Union(704, typeof(PaymentIntentCancelledEventMessage))]
    [Union(705, typeof(PaymentIntentExpiredEventMessage))]
    [Union(706, typeof(PaymentIntentFailedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
