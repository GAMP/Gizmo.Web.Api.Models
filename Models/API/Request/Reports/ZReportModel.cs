using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Z Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ZReportModel : IWebApiModel
    {
        /// <summary>
        /// Filtered Date From.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filtered Date To.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Company Name.
        /// </summary>
        [MessagePack.Key(2)]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(4)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// Filtered Financial Report Type.
        /// </summary>
        [MessagePack.Key(7)]
        public FinancialReportTypes FinancialReportType { get; set; }

        /// <summary>
        /// List of deposit operations performed during the reporting period.
        /// </summary>
        [MessagePack.Key(8)]
        public List<AccountTransactionDTOModel> Deposits { get; set; } = new List<AccountTransactionDTOModel>();

        /// <summary>
        /// List of withdrawal operations performed during the reporting period.
        /// </summary>
        [MessagePack.Key(9)]
        public List<AccountTransactionDTOModel> Withdrawals { get; set; } = new List<AccountTransactionDTOModel>();

        /// <summary>
        /// List of deposit void operations performed during the reporting period.
        /// </summary>
        [MessagePack.Key(10)]
        public List<AccountTransactionDTOModel> DepositVoids { get; set; } = new List<AccountTransactionDTOModel>();

        /// <summary>
        /// List of invoices grouped based on financial report type.
        /// </summary>
        [MessagePack.Key(11)]
        public List<FinancialReportUserGroupInvoicesDTOModel> GroupInvoices { get; set; } = new List<FinancialReportUserGroupInvoicesDTOModel>();

        /// <summary>
        /// List of voided invoices grouped based on financial report type.
        /// </summary>
        [MessagePack.Key(12)]
        public List<FinancialReportUserGroupInvoicesDTOModel> GroupVoidInvoices { get; set; } = new List<FinancialReportUserGroupInvoicesDTOModel>();

        /// <summary>
        /// Summary of deposits grouped by payment method.
        /// </summary>
        [MessagePack.Key(13)]
        public List<FinancialSummaryRecordDTOModel> DepositsSummary { get; set; } = new List<FinancialSummaryRecordDTOModel>();

        /// <summary>
        /// Summary of sales grouped by payment method.
        /// </summary>
        [MessagePack.Key(14)]
        public List<FinancialSummaryRecordDTOModel> SalesSummary { get; set; } = new List<FinancialSummaryRecordDTOModel>();

        /// <summary>
        /// Summary of voids grouped by refund method.
        /// </summary>
        [MessagePack.Key(15)]
        public List<FinancialSummaryRecordDTOModel> VoidInvoicesPaidCash { get; set; } = new List<FinancialSummaryRecordDTOModel>();

        /// <summary>
        /// Summary of voids with no refund or unpaid.
        /// </summary>
        [MessagePack.Key(16)]
        public FinancialSummaryRecordDTOModel VoidInvoicesNoRefundOrUnpaid { get; set; } = new FinancialSummaryRecordDTOModel();

        /// <summary>
        /// Summary of past sales paid within the reporting period grouped by payment method.
        /// </summary>
        [MessagePack.Key(17)]
        public List<FinancialSummaryRecordDTOModel> PastSalesPaymentsSummary { get; set; } = new List<FinancialSummaryRecordDTOModel>();

        /// <summary>
        /// List of available payment methods.
        /// </summary>
        [MessagePack.Key(18)]
        public List<ListItemDTOModel> PaymentMethods { get; set; } = new List<ListItemDTOModel>();

        /// <summary>
        /// List of register transactions performed during the reporting period.
        /// </summary>
        [MessagePack.Key(19)]
        public List<RegisterTransactionDTOModel> RegisterTransactions { get; set; } = new List<RegisterTransactionDTOModel>();

        /// <summary>
        /// Z information in case the financial report type is Z.
        /// </summary>
        [MessagePack.Key(20)]
        public ZDTOModel Z { get; set; } = new ZDTOModel();
    }

    /// <summary>
    /// Z Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ZReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        /// <summary>
        /// Filter Date.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public DateTime Date { get; set; }
    }
}
