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
        /// Discount type.
        /// </summary>
        [MessagePack.Key(2)]
        public DiscountType? Type { get; set; }
    }
}
