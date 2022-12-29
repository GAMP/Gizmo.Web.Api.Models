using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction model.
    /// </summary>
    [MessagePackObject]
    public sealed class PointTransactionModel : IPointTransactionApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the points transaction was created.
        /// </summary>
        [Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [Key(2)]
        public int Balance { get; set; }

        /// <summary>
        /// The Id of the operator this deposit transaction is associated with.
        /// </summary>
        [Key(3)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this deposit transaction is associated with.
        /// </summary>
        [Key(4)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this deposit transaction is associated with.
        /// </summary>
        [Key(5)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Gets or sets transaction balance.
        /// </summary>
        [Key(6)]
        public bool IsVoided { get; set; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [Key(7)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        [Key(8)]
        public PointsTransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [Key(9)]
        public int Amount { get; set; }

        #endregion
    }
}
