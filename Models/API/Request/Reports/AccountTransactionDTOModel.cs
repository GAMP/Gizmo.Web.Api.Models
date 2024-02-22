using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account Transaction.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class AccountTransactionDTOModel
    {
        /// <summary>
        /// The creation time of the account transaction.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The type of the transaction.
        /// </summary>
        [MessagePack.Key(1)]
        public DepositTransactionType TransactionType { get; set; }

        /// <summary>
        /// The payment type Id of the transaction.
        /// </summary>
        [MessagePack.Key(2)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// The payment type name of the transaction.
        /// </summary>
        [MessagePack.Key(3)]
        public string? PaymentMethodName { get; set; }

        /// <summary>
        /// The amount of the transaction.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The quantity of the transactions with the specific amount, in case of grouped transactions.
        /// </summary>
        [MessagePack.Key(5)]
        public int Quantity { get; set; }

        /// <summary>
        /// The total amount of the transactions with the specific amount, in case of grouped transactions.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Total { get; set; }

        /// <summary>
        /// The Id of the operator performed the account transaction.
        /// </summary>
        [MessagePack.Key(7)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the group to which the user belongs.
        /// </summary>
        [MessagePack.Key(8)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The user is guest.
        /// </summary>
        [MessagePack.Key(9)]
        public bool IsGuest { get; set; }

        /// <summary>
        /// Is Void.
        /// </summary>
        [MessagePack.Key(10)]
        public bool IsVoid { get; set; }
    }
}
