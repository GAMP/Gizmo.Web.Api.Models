using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CompanionFilterModel : IModelFilter<CompanionModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filters by assigned registers.
        /// </summary>
        [MessagePack.Key(2)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filters by assigned branches.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BranchId { get; set; }
    }
}
