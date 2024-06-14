namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order line delivery status change event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Change", "ORDER_LINE_DELIVERY_STATUS_CHANGE_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates order line delivery status change", "ORDER_LINE_DELIVERY_STATUS_CHANGE_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class OrderLineDeliveryStatusChangeEventMessage : OrderEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderLineDeliveryStatusChangeEventMessage() : base()
        { }

        /// <summary>
        /// Order line id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderLineId
        {
            get; init;
        }

        /// <summary>
        /// Indicates if order line is delivered.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsDelivered
        {
            get; init;
        }

        /// <summary>
        /// Currently delivered quantity.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal DeliveredQuantity
        {
            get; init;
        }
    }
}
