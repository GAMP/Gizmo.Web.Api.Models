using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockReportModel : IWebApiModel
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
        /// List of products with stock.
        /// </summary>
        [MessagePack.Key(5)]
        public List<ProductStockDTOModel> Products { get; set; }
    }

    /// <summary>
    /// Stock Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockReportParametersModel : IWebApiModel, IUriParametersQuery
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
    }

    /// <summary>
    /// Product Stock Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ProductStockDTOModel
    {
        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? ProductName { get; set; }

        /// <summary>
        /// Initial number of items in stock.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Initial { get; set; }

        /// <summary>
        /// Number of items added in stock.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Added { get; set; }

        /// <summary>
        /// Number of items removed from stock.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Removed { get; set; }

        /// <summary>
        /// Manually set stock to specific number of items.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Set { get; set; }

        /// <summary>
        /// The number of items sold of the product.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Sold { get; set; }

        /// <summary>
        /// The number of items returned of the product.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal Returned { get; set; }

        /// <summary>
        /// Number of items the stock left with.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Final { get; set; }

        /// <summary>
        /// Difference between initial and final stock.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Diff { get; set; }
    }
}
