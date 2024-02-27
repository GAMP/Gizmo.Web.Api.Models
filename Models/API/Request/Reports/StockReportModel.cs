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
        /// List of products with stock.
        /// </summary>
        [MessagePack.Key(0)]
        public List<ProductStockDTOModel> Products { get; set; } = new List<ProductStockDTOModel>();
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
}
