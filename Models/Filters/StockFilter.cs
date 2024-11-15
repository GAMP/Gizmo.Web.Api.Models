using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockFilter : IModelFilter<StockModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filters by stock type.
        /// </summary>
        [MessagePack.Key(2)]
        public StockType? Type { get; set; }

        /// <summary>
        /// Filters by assigned branches.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BranchId { get; set; }

        /// <summary>
        /// Filters by deleted status.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? IsDeleted { get; set; }
    }
}
