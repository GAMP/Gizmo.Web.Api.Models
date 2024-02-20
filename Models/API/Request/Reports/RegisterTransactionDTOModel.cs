using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register Transaction.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class RegisterTransactionDTOModel
    {
        /// <summary>
        /// The creation time of the register transaction.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The type of the transaction.
        /// </summary>
        [MessagePack.Key(1)]
        public RegisterTransactionType TransactionType { get; set; }

        /// <summary>
        /// The payment type name of the transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public string PaymentMethodName { get; set; }

        /// <summary>
        /// The amount of the transaction.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The quantity of the transactions with the specific amount, in case of grouped transactions.
        /// </summary>
        [MessagePack.Key(4)]
        public int Quantity { get; set; }

        /// <summary>
        /// The total amount of the transactions with the specific amount, in case of grouped transactions.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Total { get; set; }

        /// <summary>
        /// The Id of the operator performed the register transaction.
        /// </summary>
        [MessagePack.Key(6)]
        public int? OperatorId { get; set; }

    }
}
