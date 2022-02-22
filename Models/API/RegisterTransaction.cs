using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class RegisterTransaction : RegisterTransactionModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the register transaction was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the operator this register transaction is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this register transaction is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(103)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this register transaction is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(104)]
        public int? RegisterId { get; set; }

        #endregion
    }
}