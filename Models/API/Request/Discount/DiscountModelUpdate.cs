using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount update model.
    /// </summary>
    public sealed class DiscountModelUpdate : IDiscountModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(2)]
        public string? Description { get; init; } = null!;

        /// <summary>
        /// Apply type.
        /// </summary>
        [MessagePack.Key(3)]
        public DiscountApplyType ApplyType { get; init; }

        /// <summary>
        /// Gets or sets calculation type.
        /// </summary>
        [MessagePack.Key(4)]
        public DiscountCalculationType CalculationType { get; init; }

        /// <summary>
        /// Gets or sets discount reward type.
        /// </summary>
        [MessagePack.Key(5)]
        public DiscountRewardType RewardType { get; init; }

        /// <summary>
        /// Target group requirement.
        /// </summary>
        [MessagePack.Key(6)]
        public TargetGroupRequirement Requirement { get; init; }

        /// <summary>
        /// Value.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal Value { get; set; }

        /// <summary>
        /// Discount period.
        /// </summary>
        [MessagePack.Key(8)]
        public PeriodModel Period { get; init; } = new PeriodModel();

    }
}
