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
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the points transaction was created.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [DataMember()]
        [MessagePack.Key(102)]
        public int Balance { get; set; }

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

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [DataMember()]
        [MessagePack.Key(106)]
        public bool IsVoided { get; set; }

        #endregion
    }
}
