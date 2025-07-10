namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model create.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DiscountModelCreate : IDiscountModel
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public string? Description { get; init; } = null!;

        /// <summary>
        /// Apply type.
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
        /// Discount period.
        /// </summary>
        [MessagePack.Key(7)]
        public PeriodModel Period { get; init; } = new PeriodModel();

        /// <summary>
        /// Products that are part of this discount.
        /// </summary>
        [MessagePack.Key(8)]
        public TargetGroupModel? Product { get; init; }

        /// <summary>
        /// Time products that are part of this discount.
        /// </summary>
        [MessagePack.Key(9)]
        public TargetGroupModel? TimeProduct { get; init; }

        /// <summary>
        /// Time product groups that are part of this discount.
        /// </summary>
        [MessagePack.Key(10)]
        public TargetGroupModel? ProductGroup { get; init; }

        /// <summary>
        /// Bill profiles that are part of this discount.
        /// </summary>
        [MessagePack.Key(11)]
        public TargetGroupModel? BillProfile { get; init; }

        /// <summary>
        /// Payment methods that are part of this discount.
        /// </summary>
        [MessagePack.Key(12)]
        public TargetGroupModel? PaymentMethod { get; init; }
    }
}
