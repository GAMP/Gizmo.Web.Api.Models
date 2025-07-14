using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
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
        public decimal Value { get; init; }

        /// <summary>
        /// Indicates if the discount is disabled.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Discount period.
        /// </summary>
        [MessagePack.Key(9)]
        public PeriodModel Period { get; init; } = new PeriodModel();

        /// <summary>
        /// Products that are part of this discount.
        /// </summary>
        [MessagePack.Key(10)]
        public TargetGroupModel? Product { get; init; }

        /// <summary>
        /// Time products that are part of this discount.
        /// </summary>
        [MessagePack.Key(11)]
        public TargetGroupModel? TimeProduct { get; init; }

        /// <summary>
        /// Time product groups that are part of this discount.
        /// </summary>
        [MessagePack.Key(12)]
        public TargetGroupModel? ProductGroup { get; init; }

        /// <summary>
        /// Bill profiles that are part of this discount.
        /// </summary>
        [MessagePack.Key(13)]
        public TargetGroupModel? BillProfile { get; init; }

        /// <summary>
        /// Payment methods that are part of this discount.
        /// </summary>
        [MessagePack.Key(14)]
        public TargetGroupModel? PaymentMethod { get; init; }

    }
}
