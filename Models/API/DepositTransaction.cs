using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class DepositTransaction : DepositTransactionModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the deposit transaction was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The deposit balance of the user after this deposit transaction.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public decimal Balance { get; set; }

        /// <summary>
        /// The Id of the operator this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(103)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(104)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(105)]
        public int? RegisterId { get; set; }

        #endregion
    }
}