using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    public class DepositTransaction : DepositTransactionModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The date that the deposit transaction was created.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// The deposit balance of the user after this deposit transaction.
        /// </summary>
        [DataMember]
        public decimal Balance { get; set; }

        /// <summary>
        /// The Id of the operator this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        public int? RegisterId { get; set; }

        #endregion
    }
}