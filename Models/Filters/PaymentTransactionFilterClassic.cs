using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionFilterClassic : IModelFilterClassic<PaymentTransactionModel>
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
    }
}
