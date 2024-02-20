using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Financial Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FinancialReportModel : IWebApiModel
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
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string OperatorName { get; set; }

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string RegisterName { get; set; }

        /// <summary>
        /// Filtered Financial Report Type.
        /// </summary>
        [MessagePack.Key(9)]
        public FinancialReportTypes FinancialReportType { get; set; }

        /// <summary>
        /// List of deposit operations performed during the reporting period.
        /// </summary>
        [MessagePack.Key(10)]
        public List<AccountTransactionDTO> Deposits { get; set; } = new List<AccountTransactionDTO>();

        /// <summary>
        /// List of withdrawal operations performed during the reporting period.
        /// </summary>
        [MessagePack.Key(11)]
        public List<AccountTransactionDTO> Withdrawals { get; set; } = new List<AccountTransactionDTO>();

        /// <summary>
        /// List of deposit void operations performed during the reporting period.
        /// </summary>
        [MessagePack.Key(12)]
        public List<AccountTransactionDTO> DepositVoids { get; set; } = new List<AccountTransactionDTO>();

        /// <summary>
        /// List of invoices grouped based on financial report type.
        /// </summary>
        [MessagePack.Key(13)]
        public List<FinancialReportUserGroupInvoicesDTO> GroupInvoices { get; set; } = new List<FinancialReportUserGroupInvoicesDTO>();

        /// <summary>
        /// List of voided invoices grouped based on financial report type.
        /// </summary>
        [MessagePack.Key(14)]
        public List<FinancialReportUserGroupInvoicesDTO> GroupVoidInvoices { get; set; } = new List<FinancialReportUserGroupInvoicesDTO>();

        /// <summary>
        /// Summary of deposits grouped by payment method.
        /// </summary>
        [MessagePack.Key(15)]
        public List<FinancialSummaryRecordDTO> DepositsSummary { get; set; } = new List<FinancialSummaryRecordDTO>();

        /// <summary>
        /// Summary of sales grouped by payment method.
        /// </summary>
        [MessagePack.Key(16)]
        public List<FinancialSummaryRecordDTO> SalesSummary { get; set; } = new List<FinancialSummaryRecordDTO>();

        /// <summary>
        /// Summary of voids grouped by refund method.
        /// </summary>
        [MessagePack.Key(17)]
        public List<FinancialSummaryRecordDTO> VoidInvoicesPaidCash { get; set; } = new List<FinancialSummaryRecordDTO>();

        /// <summary>
        /// Summary of voids with no refund or unpaid.
        /// </summary>
        [MessagePack.Key(18)]
        public FinancialSummaryRecordDTO VoidInvoicesNoRefundOrUnpaid { get; set; } = new FinancialSummaryRecordDTO();

        /// <summary>
        /// Summary of past sales paid within the reporting period grouped by payment method.
        /// </summary>
        [MessagePack.Key(19)]
        public List<FinancialSummaryRecordDTO> PastSalesPaymentsSummary { get; set; } = new List<FinancialSummaryRecordDTO>();

        /// <summary>
        /// List of available payment methods.
        /// </summary>
        [MessagePack.Key(20)]
        public List<ListItemDTO> PaymentMethods { get; set; } = new List<ListItemDTO>();

        /// <summary>
        /// List of register transactions performed during the reporting period.
        /// </summary>
        [MessagePack.Key(21)]
        public List<RegisterTransactionDTO> RegisterTransactions { get; set; } = new List<RegisterTransactionDTO>();
    }

    /// <summary>
    /// Financial Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FinancialReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Operator Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filter Register Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filter Financial Report Type.
        /// </summary>
        [MessagePack.Key(4)]
        [Required]
        public FinancialReportTypes FinancialReportType { get; set; }
    }
}
