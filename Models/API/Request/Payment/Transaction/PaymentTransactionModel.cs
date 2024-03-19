using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction model.
    /// </summary>
    /// <remarks>
    /// Represents payment transaction, includes invoice,depoist pay ins/outs etc.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionModel : IWebApiModel
    {
        /// <summary>
        /// Optional shift id.
        /// </summary>
        /// <remarks>
        /// This might be null in some cases for example for online deposit or when shifts not used.
        /// </remarks>
        [MessagePack.Key(0)]
        public int? ShiftId
        {
            get; init;
        }

        /// <summary>
        /// Optional register id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? RegisterId
        {
            get; init;
        }

        /// <summary>
        /// Optional operator id.
        /// </summary>
        /// <remarks>
        /// This might be null in some cases for example for online deposit.
        /// </remarks>
        [MessagePack.Key(2)]
        public int? OperatorId
        {
            get; init;
        }

        /// <summary>
        /// Optional user id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? UserId
        {
            get; init;
        }

        /// <summary>
        /// Gets transaction date.
        /// </summary>
        [MessagePack.Key(4)]
        [Sortable("CreatedTime")]
        public DateTime Date
        {
            get; init;
        }

        /// <summary>
        /// Gets transaction amount.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Amount
        {
            get; init;
        }

        /// <summary>
        /// Gets transaction payment method.
        /// </summary>
        [MessagePack.Key(6)]
        public int PaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// Gets payment transaction type.
        /// </summary>
        [MessagePack.Key(7)]
        public PaymentTransactionType Type
        {
            get; init;
        }

        /// <summary>
        /// Optional transaction host id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? HostId
        {
            get; init;
        }

        /// <summary>
        /// Invoice id.
        /// </summary>
        /// <remarks>
        /// This value will only be set for invoice payments.
        /// </remarks>
        [MessagePack.Key(9)]
        public int? InvoiceId
        {
            get; init;
        }

        /// <summary>
        /// Deposit payment id.
        /// </summary>
        /// <remarks>
        /// This value will only be set for deposit payments.
        /// </remarks>
        [MessagePack.Key(10)]
        public int? DepositPaymentId
        {
            get; init;
        }
    }
}
