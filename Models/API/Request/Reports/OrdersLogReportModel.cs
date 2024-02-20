using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Orders Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrdersLogReportModel : IWebApiModel
    {
        /// <summary>
        /// Report Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Date From.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filtered Date To.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Company Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string CompanyName { get; set; } = string.Empty;

        ///// <summary>
        ///// Report Type.
        ///// </summary>
        //[Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered Order Source.
        /// </summary>
        [MessagePack.Key(5)]
        public OrderSource? OrderSource { get; set; }

        /// <summary>
        /// Filtered Order Status.
        /// </summary>
        [MessagePack.Key(6)]
        public OrderStatus? OrderStatus { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(10)]
        public string? UserName { get; set; }

        /// <summary>
        /// List of orders.
        /// </summary>
        [MessagePack.Key(11)]
        public List<OrderInfoModel> Orders { get; set; } = new List<OrderInfoModel>();
    }

    /// <summary>
    /// Orders Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrdersLogReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        /// <summary>
        /// Filter Date From.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filter Date To.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Filter Order Source.
        /// </summary>
        [MessagePack.Key(2)]
        public OrderSource? OrderSource { get; set; }

        /// <summary>
        /// Filter Order Status.
        /// </summary>
        [MessagePack.Key(3)]
        public OrderStatus? OrderStatus { get; set; }

        /// <summary>
        /// Filter Operator Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? UserId { get; set; }
    }

    /// <summary>
    /// Order Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class OrderInfoModel
    {
        /// <summary>
        /// Order Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int OrderId { get; set; }

        /// <summary>
        /// Creation time of the order.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Order source.
        /// </summary>
        [MessagePack.Key(2)]
        public OrderSource OrderSource { get; set; }

        /// <summary>
        /// Order status.
        /// </summary>
        [MessagePack.Key(3)]
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Order source name.
        /// </summary>
        [MessagePack.Key(4)]
        public string? OrderSourceLiteral { get; set; }

        /// <summary>
        /// Order status name.
        /// </summary>
        [MessagePack.Key(5)]
        public string? OrderStatusName { get; set; }

        /// <summary>
        /// The Id of the operator that handled the order.
        /// </summary>
        [MessagePack.Key(6)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that handled the order.
        /// </summary>
        [MessagePack.Key(7)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The Id of the host on which the order was created.
        /// </summary>
        [MessagePack.Key(8)]
        public int? HostId { get; set; }

        /// <summary>
        /// The name of the host on which the order was created.
        /// </summary>
        [MessagePack.Key(9)]
        public string? HostName { get; set; }

        /// <summary>
        /// The Id of the register on which the order was processed.
        /// </summary>
        [MessagePack.Key(10)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the order was processed.
        /// </summary>
        [MessagePack.Key(11)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The Id of the user that created the order.
        /// </summary>
        [MessagePack.Key(12)]
        public int? UserId { get; set; }

        /// <summary>
        /// The name of the user that created the order.
        /// </summary>
        [MessagePack.Key(13)]
        public string? UserName { get; set; }

        /// <summary>
        /// The time the order was delivered or null if is not delivered yet.
        /// </summary>
        [MessagePack.Key(14)]
        public DateTime? DeliveredTime { get; set; }

        /// <summary>
        /// Total seconds between the time the order was created and the time the order was delivered, null if is not delivered yet.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal? DeliverySeconds { get; set; }

        /// <summary>
        /// Total time as text between the time the order was created and the time the order was delivered, null if is not delivered yet.
        /// </summary>
        [MessagePack.Key(16)]
        public string? DeliveryTime { get; set; }

        /// <summary>
        /// Number of items within the order.
        /// </summary>
        [MessagePack.Key(17)]
        public int ItemNumber { get; set; }

        /// <summary>
        /// The Id of the invoice that was created for the order, null if there is no related invoice.
        /// </summary>
        [MessagePack.Key(18)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// User note for the order.
        /// </summary>
        [MessagePack.Key(19)]
        public string? UserNote { get; set; }

        /// <summary>
        /// The invoice that was created for the order, null if there is no related invoice.
        /// </summary>
        [MessagePack.Key(20)]
        public InvoiceInfoModel Invoice { get; set; }
    }

}
