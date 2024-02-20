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
        public List<OrderDTOModel> Orders { get; set; } = new List<OrderDTOModel>();
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
}
