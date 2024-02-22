using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refund Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class RefundDTOModel
    {
        /// <summary>
        /// The time the refund was created.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The Id of the operator that performed the refund.
        /// </summary>
        [MessagePack.Key(1)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that performed the refund.
        /// </summary>
        [MessagePack.Key(2)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the refund performed.
        /// </summary>
        [MessagePack.Key(3)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the refund was performed.
        /// </summary>
        [MessagePack.Key(4)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// Refund method Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? RefundMethodId { get; set; }

        /// <summary>
        /// Refund method name.
        /// </summary>
        [MessagePack.Key(6)]
        public string? RefundMethodName { get; set; }

        /// <summary>
        /// Amount refunded.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal RefundedAmount { get; set; }

    }
}
