using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryAdjustmentReasonFilter : IModelFilter<InventoryAdjustmentReasonModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Is deleted.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsDeleted { get; set; }
    }
}
