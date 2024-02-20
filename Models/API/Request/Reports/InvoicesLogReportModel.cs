using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoices Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoicesLogReportModel : IWebApiModel
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
        //[MessagePack.Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered Payment Status Type.
        /// </summary>
        [MessagePack.Key(5)]
        public InvoicesLogPaymentStatusTypes? PaymentStatusType { get; set; }

        /// <summary>
        /// Filtered Voided Status Type.
        /// </summary>
        [MessagePack.Key(6)]
        public InvoicesLogVoidedStatusTypes? VoidedStatusType { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string OperatorName { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(10)]
        public string RegisterName { get; set; } = string.Empty;

        /// <summary>
        /// List of invoices.
        /// </summary>
        [MessagePack.Key(11)]
        public List<InvoiceInfoModel> Invoices { get; set; } = new List<InvoiceInfoModel>();

    }

    /// <summary>
    /// Invoices Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoicesLogReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        #region PROPERTIES

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
        /// Filter Payment Status Type.
        /// </summary>
        [MessagePack.Key(4)]
        public InvoicesLogPaymentStatusTypes? PaymentStatusType { get; set; }

        /// <summary>
        /// Filter Voided Status Type.
        /// </summary>
        [MessagePack.Key(5)]
        public InvoicesLogVoidedStatusTypes? VoidedStatusType { get; set; }

        #endregion
    }
}
