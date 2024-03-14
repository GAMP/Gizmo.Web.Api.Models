using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

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
        /// Shift id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ShiftId
        {
            get;init;
        }

        /// <summary>
        /// Operator id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? OperatorId
        {
            get;init;
        }

        /// <summary>
        /// Customer id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? CustomerId
        {
            get; init;  
        }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? PaymentMethodId
        {
            get;init;
        }

        /// <summary>
        /// Transaction type.
        /// </summary>
        [MessagePack.Key(6)]
        public PaymentTransactionType TransactionType
        {
            get; init;  
        }
    }
}
