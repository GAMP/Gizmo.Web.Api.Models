namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model.
    /// </summary>
    public interface IDiscountModel : IWebApiModel
    {
        /// <summary>
        /// Name.
        /// </summary>
        string Name { get; init; }

        /// <summary>
        /// Description.
        /// </summary>
        string? Description { get; init; }

        /// <summary>
        /// Apply type.
        /// </summary>
        public DiscountApplyType ApplyType { get; init; }

        /// <summary>
        /// Gets or sets calculation type.
        /// </summary>
        public DiscountCalculationType CalculationType { get; init; }

        /// <summary>
        /// Gets or sets discount reward type.
        /// </summary>
        public DiscountRewardType RewardType { get; init; }

        /// <summary>
        /// Target group requirement.
        /// </summary>
        public TargetGroupRequirement Requirement { get; init; }

        /// <summary>
        /// Value.
        /// </summary>
        public decimal Value { get; init; }

        /// <summary>
        /// Indicates if the discount is disabled.
        /// </summary>
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Discount period.
        /// </summary>
        public PeriodModel Period { get;}
    }
}
