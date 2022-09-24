using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OrderModelBase : CalculatedOrder
    {
        #region PROPERTIES

        /// <summary>
        /// The date that the order was created.
        /// </summary>
        [MessagePack.Key(100)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the user this order is associated with.
        /// </summary>
        [MessagePack.Key(101)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the host this order is associated with.
        /// </summary>
        [MessagePack.Key(102)]
        public int? HostId { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(103)]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// The user note of the order.
        /// </summary>
        [MessagePack.Key(104)]
        public string UserNote { get; set; }

        /// <summary>
        /// Whether the order is delivered.
        /// </summary>
        [MessagePack.Key(105)]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The Id of the operator this order is associated with.
        /// </summary>
        [MessagePack.Key(106)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this order is associated with.
        /// </summary>
        [MessagePack.Key(107)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this order is associated with.
        /// </summary>
        [MessagePack.Key(108)]
        public int? RegisterId { get; set; } 

        #endregion

    }
}