using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ScheduleFilter : IModelFilter<ScheduleModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Schedule type.
        /// </summary>
        [MessagePack.Key(2)]
        public ScheduleTypes? Type { get; set; }

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDisabled { get; set; }
    }
}
