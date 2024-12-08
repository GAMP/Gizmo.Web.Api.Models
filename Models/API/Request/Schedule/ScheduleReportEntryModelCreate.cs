using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report entry create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportEntryModelCreate
    {       
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
