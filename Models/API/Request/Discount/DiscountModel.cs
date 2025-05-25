using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack.Formatters;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountModel : IWebApiModel, IDiscountModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get;init;}

        /// <inheritdoc/>
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// Apply type, basically at what level discount is applied (order or order line)
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
        /// Indicates that discount is disabled.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Indicates that discount is deleted.
        /// </summary>
        [MessagePack.Key(9)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Discount period.
        /// </summary>
        [MessagePack.Key(10)]
        public PeriodModel Period { get; init; } = new PeriodModel();
    }
}
