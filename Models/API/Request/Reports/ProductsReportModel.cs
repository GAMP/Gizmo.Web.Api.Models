using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Products Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductsReportModel : IWebApiModel
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
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? UserName { get; set; }

        /// <summary>
        /// List of products.
        /// </summary>
        [MessagePack.Key(7)]
        public List<GroupedProductSalesDTOModel> Products { get; set; } = new List<GroupedProductSalesDTOModel>();

    }

    /// <summary>
    /// Products Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductsReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UserId { get; set; }

        /// <summary>
        /// Hide unused products.
        /// </summary>
        [MessagePack.Key(3)]
        public bool HideUnused { get; set; }
    }

    /// <summary>
    /// Sold Product Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class GroupedProductSalesDTOModel
    {
        /// <summary>
        /// The number of items sold of the product.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Sold { get; set; }

        /// <summary>
        /// The number of items returned of the product.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Returned { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Value { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [MessagePack.Key(3)]
        public int PointsValue { get; set; }

        /// <summary>
        /// The points award of the product.
        /// </summary>
        [MessagePack.Key(4)]
        public int PointsAward { get; set; }

        /// <summary>
        /// The tax amount of the product.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Tax { get; set; }

        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(6)]
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(7)]
        public string? ProductName { get; set; }
    }
}
