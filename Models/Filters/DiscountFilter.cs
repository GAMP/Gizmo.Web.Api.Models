using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountFilter : IModelFilter<DiscountModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsDisabled { get; init; }

        /// <summary>
        /// Is deleted.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDeleted { get; init; }

        /// <summary>
        /// Reward type.
        /// </summary>
        [MessagePack.Key(4)]
        public DiscountRewardType? RewardType { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? BranchId { get; init; }
    }
}
