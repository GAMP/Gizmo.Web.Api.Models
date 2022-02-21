using MessagePack;
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
    [MessagePackObject]
    public class OrderModelBase : CalculatedOrder
    {
        /// <summary>
        /// The date that the order was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the user this order is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the host this order is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public int? HostId { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(103)]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// The user note of the order.
        /// </summary>
        [DataMember]
        [MessagePack.Key(104)]
        public string UserNote { get; set; }

        /// <summary>
        /// Whether the order is delivered.
        /// </summary>
        [DataMember]
        [MessagePack.Key(105)]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The Id of the operator this order is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(106)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this order is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(107)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this order is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(108)]
        public int? RegisterId { get; set; }

    }
}