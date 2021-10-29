using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order delivered event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class OrderDeliveredEventMessage : OrderEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderDeliveredEventMessage() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets if order is delivered.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public bool IsDelivered
        {
            get; init;
        }

        /// <summary>
        /// Gets delivery time.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public DateTime? DeliverTime
        {
            get; init;
        }

        /// <summary>
        /// Gets current order line states.
        /// </summary>
        [DataMember()]
        [Key(4)]
        public IEnumerable<OrderLineStateModel> States
        {
            get; init;
        }

        #endregion
    }
}
