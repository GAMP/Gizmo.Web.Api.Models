using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order event message interface.
    /// </summary>
    [Union(0, typeof(OrderDeliveredEventMessage))]
    [Union(1, typeof(OrderInvoicedEventMessage))]
    [Union(2, typeof(OrderInvoicePaymentEventMessage))]
    [Union(3, typeof(OrderStatusChangeEventMessage))]
    public interface IOrderEventMessage
    {
    }
}
