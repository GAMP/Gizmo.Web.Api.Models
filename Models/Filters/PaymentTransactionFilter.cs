using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionFilter : IModelFilter<PaymentTransactionModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

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
        /// Include invoice payments.
        /// </summary>
        [MessagePack.Key(9)]
        public bool? IncludeInvoicePayments
        {
            get; init;
        }

        /// <summary>
        /// Include deposit payments.
        /// </summary>
        [MessagePack.Key(10)]
        public bool? IncludeDepositPayments
        {
            get;init;
        }



        /// <summary>
        /// Include deposit refund payments.
        /// </summary>
        [MessagePack.Key(11)]
        public bool? IncludeDepositRefunds
        {
            get; init;
        }

        /// <summary>
        /// Include invoice refund payments.
        /// </summary>
        [MessagePack.Key(12)]
        public bool? IncludeInvoiceRefunds
        {
            get; init;
        }

        /// <summary>
        /// Include pay-in payments.
        /// </summary>
        [MessagePack.Key(13)]
        public bool? IncludePayIns
        {
            get; init;
        }

        /// <summary>
        /// Include pay-out payments.
        /// </summary>
        [MessagePack.Key(14)]
        public bool? IncludePayOuts
        {
            get; init;
        }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(15)]
        public int? RegisterId
        {
            get;init;
        }
    }
}
