using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// POS invoice receipt table row.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoiceReceiptModel : IWebApiModel
    {
        /// <summary>
        /// Invoice identifier.
        /// </summary>
        [Key(0)]
        public int InvoiceId { get; init; }

        /// <summary>
        /// Receipt date.
        /// </summary>
        [Key(1)]
        public DateTime? Date { get; init; }

        /// <summary>
        /// Receipt type.
        /// </summary>
        [System.ComponentModel.DataAnnotations.EnumValueValidation]
        [Key(2)]
        public InvoiceReceiptType Type { get; init; }

        /// <summary>
        /// Operator identifier.
        /// </summary>
        [Key(3)]
        public int? OperatorId { get; init; }

        /// <summary>
        /// Operator username.
        /// </summary>
        [Key(4)]
        public string? OperatorName { get; init; }

        /// <summary>
        /// Shift identifier.
        /// </summary>
        [Key(5)]
        public int? ShiftId { get; init; }

        /// <summary>
        /// Register identifier.
        /// </summary>
        [Key(6)]
        public int? RegisterId { get; init; }

        /// <summary>
        /// Register name.
        /// </summary>
        [Key(7)]
        public string? RegisterName { get; init; }

        /// <summary>
        /// Companion identifier.
        /// </summary>
        [Key(8)]
        public int? CompanionId { get; init; }

        /// <summary>
        /// Companion name.
        /// </summary>
        [Key(9)]
        public string? CompanionName { get; init; }

        /// <summary>
        /// Payment methods associated with the invoice.
        /// </summary>
        [Key(10)]
        public IReadOnlyList<InvoiceReceiptPaymentMethodModel> PaymentMethods { get; set; } = [];

        /// <summary>
        /// Invoice total.
        /// </summary>
        [Key(11)]
        public decimal Total { get; init; }

        /// <summary>
        /// Applicable fiscal receipt print status.
        /// </summary>
        [System.ComponentModel.DataAnnotations.EnumValueValidation]
        [Key(12)]
        public FiscalReceiptPrintStatus FiscalReceiptPrintStatus { get; init; }
    }
}
