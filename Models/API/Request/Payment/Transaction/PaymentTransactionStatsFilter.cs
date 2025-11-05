using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionStatsFilter : IWebApiModel
    {
        /// <summary>
        /// Date from.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime? DateFrom { get; init; }

        /// <summary>
        /// Date to.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? DateTo { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? BranchId { get; init; }

        /// <summary>
        /// Shift id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ShiftId
        {
            get; init;
        }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? RegisterId
        {
            get; init;
        }

        /// <summary>
        /// Operator id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? OperatorId
        {
            get; init;
        }

        /// <summary>
        /// Customer id.
        /// </summary>
        [MessagePack.Key(6)]
        public int? UserId
        {
            get; init;
        }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? PaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// Direction type.
        /// </summary>
        [MessagePack.Key(8)]
        public PaymentTransactionDirection? PaymentDirection
        {
            get; init;
        }

        /// <summary>
        /// Include invoice transactions.
        /// </summary>
        [MessagePack.Key(9)]
        public bool? InvoiceTransactions
        {
            get; init;
        }

        /// <summary>
        /// Include deposit transactions.
        /// </summary>
        [MessagePack.Key(10)]
        public bool? DepositTransactions
        {
            get; init;
        }

        /// <summary>
        /// Include register transactions.
        /// </summary>
        [MessagePack.Key(11)]
        public bool? RegisterTransactions
        {
            get; init;
        }
    }
}
