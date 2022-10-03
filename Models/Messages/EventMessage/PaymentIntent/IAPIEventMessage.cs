using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(700, typeof(PaymentIntentCreatedEventMessage))]
    [Union(701, typeof(PaymentIntentStateChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
