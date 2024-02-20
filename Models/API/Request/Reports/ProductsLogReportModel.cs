﻿using System;
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
        public List<ProductTransactionDTOModel> ProductTransactions { get; set; }
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

    /// <summary>
    /// Product Transaction.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductTransactionDTOModel
    {
        /// <summary>
        /// The time the transaction performed.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The type of the transaction.
        /// </summary>
        [MessagePack.Key(1)]
        public ProductTransactionTypes ProductTransactionType { get; set; }

        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int ProductId { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? ProductName { get; set; }

        /// <summary>
        /// Number of items within the transaction.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The Id of the operator that performed the transaction.
        /// </summary>
        [MessagePack.Key(5)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that performed the transaction.
        /// </summary>
        [MessagePack.Key(6)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the transaction was performed.
        /// </summary>
        [MessagePack.Key(7)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the transaction was performed.
        /// </summary>
        [MessagePack.Key(8)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The Id of the customer for whom the transaction was created.
        /// </summary>
        [MessagePack.Key(9)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// The username of the customer for whom the transaction was created.
        /// </summary>
        [MessagePack.Key(10)]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Id of the invoice that is related to the transaction.
        /// </summary>
        [MessagePack.Key(11)]
        public int? InvoiceId { get; set; }
    }
}
