using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that cane be applied when searching to report presets.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetFilter : IModelFilter<ReportPresetModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = [];
    }
}
