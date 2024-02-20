using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product Transaction.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductTransactionDTOModel
    {
        /// <summary>
        /// The time the transaction performed.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The type of the transaction.
        /// </summary>
        [MessagePack.Key(1)]
        public ProductTransactionTypes ProductTransactionType { get; set; }

        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int ProductId { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? ProductName { get; set; }

        /// <summary>
        /// Number of items within the transaction.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The Id of the operator that performed the transaction.
        /// </summary>
        [MessagePack.Key(5)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that performed the transaction.
        /// </summary>
        [MessagePack.Key(6)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the transaction was performed.
        /// </summary>
        [MessagePack.Key(7)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the transaction was performed.
        /// </summary>
        [MessagePack.Key(8)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// The Id of the customer for whom the transaction was created.
        /// </summary>
        [MessagePack.Key(9)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// The username of the customer for whom the transaction was created.
        /// </summary>
        [MessagePack.Key(10)]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Id of the invoice that is related to the transaction.
        /// </summary>
        [MessagePack.Key(11)]
        public int? InvoiceId { get; set; }
    }
}
