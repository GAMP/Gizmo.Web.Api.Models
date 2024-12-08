using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report recipient filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportRecipientFilter : IModelFilter<RecipientModel>
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
        /// Schedule report id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ScheduleReportId { get; init; }

        /// <summary>
        /// Is deleted filter.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDisabled { get; init; }
    }
}
