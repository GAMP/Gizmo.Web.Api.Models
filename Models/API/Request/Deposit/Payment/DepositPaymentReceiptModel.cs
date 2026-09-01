using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// POS deposit payment receipt table row.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class DepositPaymentReceiptModel : IWebApiModel
    {
        /// <summary>
        /// Deposit payment identifier.
        /// </summary>
        [Sortable("Id")]
        [Key(0)]
        public int DepositPaymentId { get; init; }

        /// <summary>
        /// Receipt date.
        /// </summary>
        [Sortable("SortDate")]
        [Key(1)]
        public DateTime Date { get; init; }

        /// <summary>
        /// Operator identifier.
        /// </summary>
        [Key(2)]
        public int? OperatorId { get; init; }

        /// <summary>
        /// Operator username.
        /// </summary>
        [Key(3)]
        public string? OperatorName { get; init; }

        /// <summary>
        /// Shift identifier.
        /// </summary>
        [Key(4)]
        public int? ShiftId { get; init; }

        /// <summary>
        /// Register identifier.
        /// </summary>
        [Key(5)]
        public int? RegisterId { get; init; }

        /// <summary>
        /// Register name.
        /// </summary>
        [Key(6)]
        public string? RegisterName { get; init; }

        /// <summary>
        /// Companion identifier.
        /// </summary>
        [Key(7)]
        public int? CompanionId { get; init; }

        /// <summary>
        /// Companion name.
        /// </summary>
        [Key(8)]
        public string? CompanionName { get; init; }

        /// <summary>
        /// Payment method identifier.
        /// </summary>
        [Key(9)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Payment method name.
        /// </summary>
        [Key(10)]
        public string? PaymentMethodName { get; init; }

        /// <summary>
        /// Deposit payment amount.
        /// </summary>
        [Key(11)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Fiscal receipt print status.
        /// </summary>
        [System.ComponentModel.DataAnnotations.EnumValueValidation]
        [Key(12)]
        public FiscalReceiptPrintStatus FiscalReceiptPrintStatus { get; init; }
    }
}
