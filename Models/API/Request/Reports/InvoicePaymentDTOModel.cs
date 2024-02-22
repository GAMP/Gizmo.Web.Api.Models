using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class InvoicePaymentDTOModel// : InvoicesInfoDTO
    {
        /// <summary>
        /// The time that invoice payment was created.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Invoice Id.
        /// </summary>
        [MessagePack.Key(1)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Payment method Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Payment method name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? PaymentMethodName { get; set; }

        /// <summary>
        /// Amount of the invoice payment.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Refunded amount of the invoice payment.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal RefundedAmount { get; set; }

        /// <summary>
        /// Refunded status of the invoice payment.
        /// </summary>
        [MessagePack.Key(6)]
        public RefundStatus RefundStatus { get; set; }

        /// <summary>
        /// Refund method Id of the invoice payment.
        /// </summary>
        [MessagePack.Key(7)]
        public int RefundMethodId { get; set; }

        /// <summary>
        /// The Id of the operator that performed the invoice payment.
        /// </summary>
        [MessagePack.Key(8)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that performed the invoice payment.
        /// </summary>
        [MessagePack.Key(9)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the invoice payment was performed.
        /// </summary>
        [MessagePack.Key(10)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the invoice payment was performed.
        /// </summary>
        [MessagePack.Key(11)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The Id of the shift that the invoice payment belongs.
        /// </summary>
        [MessagePack.Key(12)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the user group that the user belongs.
        /// </summary>
        [MessagePack.Key(13)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The user is guest.
        /// </summary>
        [MessagePack.Key(14)]
        public bool IsGuest { get; set; }

        /// <summary>
        /// Invoice total amount.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal InvoiceTotal { get; set; }

        /// <summary>
        /// Invoice amount outstanding.
        /// </summary>
        [MessagePack.Key(16)]
        public decimal InvoiceOutstanding { get; set; }

        /// <summary>
        /// The invoice is voided.
        /// </summary>
        [MessagePack.Key(17)]
        public bool InvoiceIsVoided { get; set; }

        /// <summary>
        /// The time the invoice related to the order was voided, null if not voided.
        /// </summary>
        [MessagePack.Key(18)]
        public DateTime? VoidCreatedTime { get; set; }

        /// <summary>
        /// The Id of the operator that performed the void.
        /// </summary>
        [MessagePack.Key(19)]
        public int? VoidOperatorId { get; set; }
    }
}
