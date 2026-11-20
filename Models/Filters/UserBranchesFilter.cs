using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for the branches visible to the user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserBranchesFilter : IModelFilter<UserBranchModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result (not used).
        /// </summary>
        [Key(1)]
        public List<string> Expand { get; set; } = new();
    }
}
