using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User current usage filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserCurrentUsageFilter : IModelFilter<UserCurrentUsageModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();
    }
}
