using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionFilter : IModelFilterClassic<PaymentTransactionModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPaginationClassic Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Date from.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime DateFrom { get; init; }

        /// <summary>
        /// Date to.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime DateTo { get; init; }

        /// <summary>
        /// Shift id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? ShiftId
        {
            get; init;
        }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? RegisterId
        {
            get; init;
        }

        /// <summary>
        /// Operator id.
        /// </summary>
        [MessagePack.Key(6)]
        public int? OperatorId
        {
            get; init;
        }

        /// <summary>
        /// Customer id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? UserId
        {
            get; init;
        }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? PaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// Direction type.
        /// </summary>
        [MessagePack.Key(9)]
        public PaymentTransactionDirection? PaymentDirection
        {
            get; init;
        }

        /// <summary>
        /// Include invoice transactions.
        /// </summary>
        [MessagePack.Key(10)]
        public bool? InvoiceTransactions
        {
            get; init;
        }

        /// <summary>
        /// Include deposit transactions.
        /// </summary>
        [MessagePack.Key(11)]
        public bool? DepositTransactions
        {
            get; init;
        }

        /// <summary>
        /// Include register transactions.
        /// </summary>
        [MessagePack.Key(12)]
        public bool? RegisterTransactions
        {
            get; init;
        }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(13)]
        public int? BranchId { get; init; }

        /// <summary>
        /// Implicit conversion to <see cref="PaymentTransactionStatsFilter"/>.
        /// </summary>
        /// <param name="filter">Payment transactions filter.</param>
        public static implicit operator PaymentTransactionStatsFilter(PaymentTransactionFilter filter) => new()
        {
            BranchId = filter.BranchId,
            DateFrom = filter.DateFrom,
            DateTo = filter.DateTo,
            DepositTransactions = filter.DepositTransactions,
            RegisterTransactions = filter.RegisterTransactions,
            InvoiceTransactions = filter.InvoiceTransactions,
            OperatorId = filter.OperatorId,
            PaymentDirection = filter.PaymentDirection,
            PaymentMethodId = filter.PaymentMethodId,
            RegisterId = filter.RegisterId,
            ShiftId = filter.ShiftId,
            UserId = filter.UserId,
        };
    }
}
