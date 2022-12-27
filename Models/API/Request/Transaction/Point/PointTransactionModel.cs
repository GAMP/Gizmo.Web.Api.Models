using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Point
{
    /// <summary>
    /// Point transaction model.
    /// </summary>
    [Serializable()]
    [MessagePackObject()]
    public class PointTransactionModel : PointTransactionModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the points transaction was created.
        /// </summary>
        [Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [Key(102)]
        public int Balance { get; set; }

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

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [Key(106)]
        public bool IsVoided { get; set; }

        #endregion
    }
}
