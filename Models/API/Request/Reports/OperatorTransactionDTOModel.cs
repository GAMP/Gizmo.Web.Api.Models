using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator Transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OperatorTransactionDTOModel
    {
        /// <summary>
        /// Operator name.
        /// </summary>
        [Key(0)]
        public string OperatorName { get; set; } = string.Empty;

        /// <summary>
        /// The creation time of the transaction.
        /// </summary>
        [Key(1)]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The creation time of the invoice related to the transaction.
        /// </summary>
        [Key(2)]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The transaction title.
        /// </summary>
        [Key(3)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The username of the customer for whom the transaction was created.
        /// </summary>
        [Key(4)]
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// The Id of the invoice related to the transaction.
        /// </summary>
        [Key(5)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// The value of the transaction.
        /// </summary>
        [Key(6)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The amount of money or points moved by the transaction.
        /// </summary>
        [Key(7)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Payment Method Id.
        /// </summary>
        [Key(8)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Payment Method Name.
        /// </summary>
        [Key(9)]
        public string PaymentMethodName { get; set; } = string.Empty;

        /// <summary>
        /// Register Name.
        /// </summary>
        [Key(10)]
        public string RegisterName { get; set; } = string.Empty;

        /// <summary>
        /// Note.
        /// </summary>
        [Key(11)]
        public string Note { get; set; } = string.Empty;
    }
}
