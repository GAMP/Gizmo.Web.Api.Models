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
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? UserName { get; set; }

        /// <summary>
        /// List of products.
        /// </summary>
        [MessagePack.Key(2)]
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
        /// Filter Product Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? UserId { get; set; }

        /// <summary>
        /// Hide unused products.
        /// </summary>
        [MessagePack.Key(4)]
        public bool HideUnused { get; set; }
    }
}
