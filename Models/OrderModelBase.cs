using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order.
    /// </summary>
    [Serializable]
    [DataContract]
    public class OrderModelBase : CalculatedOrder
    {
        /// <summary>
        /// The date that the order was created.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the user this order is associated with.
        /// </summary>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        [DataMember]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public string UserNote { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The Id of the operator this order is associated with.
        /// </summary>
        [DataMember]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this order is associated with.
        /// </summary>
        [DataMember]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this order is associated with.
        /// </summary>
        [DataMember]
        public int? RegisterId { get; set; }

    }
}