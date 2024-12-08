using System;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report entry model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportEntryModel : IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int ScheduleReportId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public Guid ReportType { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public ReportPresetRange Range { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int? ReportPresetId { get; init; }
    }
}
