using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order delivery status change event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Change", "ORDER_DELIVERY_STATUS_CHANGE_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates order delivery status change", "ORDER_DELIVERY_STATUS_CHANGE_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class OrderDeliveryStatusChangeEventMessage : OrderEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderDeliveryStatusChangeEventMessage() : base()
        { }


        /// <summary>
        /// Indicates if order is delivered.
        /// </summary>
        [Key(2)]
        public bool IsDelivered
        {
            get; init;
        }
    }
}
