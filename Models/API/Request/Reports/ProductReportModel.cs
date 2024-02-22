using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductReportModel : IWebApiModel
    {
        /// <summary>
        /// Report Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

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
        public string? CompanyName { get; set; }

        ///// <summary>
        ///// Report Type.
        ///// </summary>
        //[MessagePack.Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered Product Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int ProductId { get; set; }

        /// <summary>
        /// Filtered Product Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? ProductName { get; set; }

        /// <summary>
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string? UserName { get; set; }

        /// <summary>
        /// List of product sales per user group.
        /// </summary>
        [MessagePack.Key(9)]
        public List<UserGroupProductsSoldDTOModel> UserGroups { get; set; } = new List<UserGroupProductsSoldDTOModel>();

        /// <summary>
        /// List of records for the general sales chart.
        /// </summary>
        [MessagePack.Key(10)]
        public List<ChartRecordDTOModel> SalesChart { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// List of records for the sales per day chart.
        /// </summary>
        [MessagePack.Key(11)]
        public List<ChartRecordDTOModel> SalesChartPerDay { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// List of records for the sales per hour chart.
        /// </summary>
        [MessagePack.Key(12)]
        public List<ChartRecordDTOModel> SalesChartPerHour { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// List of records with minimum values for the stock chart.
        /// </summary>
        [MessagePack.Key(13)]
        public List<ChartRecordDTOModel> StockChartMin { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// List of records with maximum values for the stock chart.
        /// </summary>
        [MessagePack.Key(14)]
        public List<ChartRecordDTOModel> StockChartMax { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// List of records for the time usage chart.
        /// </summary>
        [MessagePack.Key(15)]
        public List<TimeUsageChartRecordDTOModel> TimeUsageChart { get; set; } = new List<TimeUsageChartRecordDTOModel>();
    }

    /// <summary>
    /// Product Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Product Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int ProductId { get; set; }

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? UserId { get; set; }
    }
}
