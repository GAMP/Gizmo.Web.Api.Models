using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for orders.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrdersFilter : IModelFilter<OrderModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Return orders where the date greater than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return orders where the date less than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return orders with the specified order status.
        /// </summary>
        [MessagePack.Key(4)]
        public OrderStatusFilter? Status { get; set; }

        /// <summary>
        /// Return orders of the specified user.
        /// </summary>
        [MessagePack.Key(5)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return orders of the specified host.
        /// </summary>
        [MessagePack.Key(6)]
        public int? HostId { get; set; }

        /// <summary>
        /// Return orders of the specified payment status.
        /// </summary>
        [MessagePack.Key(7)]
        public InvoiceStatus? InvoiceStatus { get; set; }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? BranchId { get; set; }

        /// <summary>
        /// Order delivery status.
        /// </summary>
        [MessagePack.Key(10)]
        public bool? IsDelivered { get; set; }

        /// <summary>
        /// Shift id.
        /// </summary>
        [MessagePack.Key(11)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// Created by operator id.
        /// </summary>
        [MessagePack.Key(12)]
        public int? OperatorId { get; init; }
    }
}
