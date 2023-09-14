using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request type filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestTypeFilter : IModelFilter<AssistanceRequestTypeModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filter soft deleted entries.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDeleted { get; set; }
    }
}
