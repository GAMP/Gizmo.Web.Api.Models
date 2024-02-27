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
        /// Filtered Payment Status Type.
        /// </summary>
        [MessagePack.Key(0)]
        public InvoicesLogPaymentStatusTypes? PaymentStatusType { get; set; }

        /// <summary>
        /// Filtered Voided Status Type.
        /// </summary>
        [MessagePack.Key(1)]
        public InvoicesLogVoidedStatusTypes? VoidedStatusType { get; set; }

        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(5)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// List of invoices.
        /// </summary>
        [MessagePack.Key(6)]
        public List<InvoiceDTOModel> Invoices { get; set; } = new List<InvoiceDTOModel>();
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
