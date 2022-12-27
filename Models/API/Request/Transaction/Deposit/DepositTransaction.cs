using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Deposit
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DepositTransaction : DepositTransactionModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the deposit transaction was created.
        /// </summary>
        [Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The deposit balance of the user after this deposit transaction.
        /// </summary>
        [Key(102)]
        public decimal Balance { get; set; }

        /// <summary>
        /// The Id of the operator this deposit transaction is associated with.
        /// </summary>
        [Key(103)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this deposit transaction is associated with.
        /// </summary>
        [Key(104)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this deposit transaction is associated with.
        /// </summary>
        [Key(105)]
        public int? RegisterId { get; set; }

        #endregion
    }
}