using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order status change event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Change", "ORDER_STATUS_CHANGE_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates order status change", "ORDER_STATUS_CHANGE_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class OrderStatusChangeEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderStatusChangeEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new status.
        /// </summary>
        [Key(2)]
        public OrderStatus Status
        {
            get; init;
        }

        /// <summary>
        /// Gets previous status.
        /// </summary>
        [Key(3)]
        public OrderStatus? PreviousStatus
        {
            get; init;
        }

        #endregion
    }
}
