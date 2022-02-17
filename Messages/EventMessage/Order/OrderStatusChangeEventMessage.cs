using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order status change event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class OrderStatusChangeEventMessage : OrderEventMessageBase
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
        [DataMember()]
        [Key(2)]
        public OrderStatus NewStatus
        {
            get; init;
        }

        /// <summary>
        /// Gets old status.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public OrderStatus? OldStatus
        {
            get; init;
        }

        #endregion
    }
}
