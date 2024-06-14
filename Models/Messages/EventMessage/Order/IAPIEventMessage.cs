using MessagePack;

namespace Gizmo.Web.Api.Messaging
{    
    [Union(200, typeof(OrderCreatedEventMessage))]
    [Union(201, typeof(OrderStatusChangeEventMessage))]
    [Union(202, typeof(OrderDeliveryStatusChangeEventMessage))]
    [Union(203, typeof(OrderLineDeliveryStatusChangeEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
