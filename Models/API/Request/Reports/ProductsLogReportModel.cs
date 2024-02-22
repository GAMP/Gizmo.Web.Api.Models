using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Products Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductsLogReportModel : IWebApiModel
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
        public int? ProductId { get; set; }

        /// <summary>
        /// Filtered Product Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? ProductName { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(8)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered Product Transaction Type Id.
        /// </summary>
        [MessagePack.Key(9)]
        public ProductTransactionTypes? ProductTransactionType { get; set; }

        /// <summary>
        /// List of product transactions within the reporting period.
        /// </summary>
        [MessagePack.Key(10)]
        public List<ProductTransactionDTOModel> ProductTransactions { get; set; } = new List<ProductTransactionDTOModel>();
    }

    /// <summary>
    /// Products Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductsLogReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Operator Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filter Product Transaction Type.
        /// </summary>
        [MessagePack.Key(4)]
        public ProductTransactionTypes? ProductTransactionType { get; set; }
    }
}
