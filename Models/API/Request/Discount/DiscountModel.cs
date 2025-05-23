using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountModel : IWebApiModel, IDiscountModel
    {
        /// <inheritdoc/>
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string? Description { get; init; }

        /// <summary>
        /// Apply type, basically at what level discount is applied (order or order line)
        /// </summary>

        [MessagePack.Key(2)]
        public DiscountApplyType ApplyType { get; init; }

        /// <summary>
        /// Gets or sets calculation type.
        /// </summary>
        [MessagePack.Key(3)]
        public DiscountCalculationType CalculationType { get; init; }

        /// <summary>
        /// Gets or sets discount reward type.
        /// </summary>
        [MessagePack.Key(4)]
        public DiscountRewardType RewardType { get; init; }

        /// <summary>
        /// Target group requirement.
        /// </summary>
        [MessagePack.Key(5)]
        public TargetGroupRequirement Requirement { get; init; }

        /// <summary>
        /// Value.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Value { get; set; }

        /// <summary>
        /// Indicates that discount is disabled.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Indicates that discount is deleted.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Discount period.
        /// </summary>
        [MessagePack.Key(9)]
        public PeriodModel Period { get; init; } = new PeriodModel();
    }
}
