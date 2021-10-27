using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction model.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [MessagePackObject()]
    public class PointTransactionModel : PointTransactionModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the points transaction was created.
        /// </summary>
        [DataMember]
        [Key(4)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [DataMember()]
        [Key(5)]
        public int Balance { get; set; }

        /// <summary>
        /// The Id of the operator this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [Key(6)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [Key(7)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this deposit transaction is associated with.
        /// </summary>
        [DataMember]
        [Key(8)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [DataMember()]
        [Key(9)]
        public bool IsVoided { get; set; }

        #endregion
    }
}
