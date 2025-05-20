using System;
using System.Collections.Generic;
using System.Linq;
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
       
        /// <summary>
        /// Schedule report id.
        /// </summary>
        [MessagePack.Key(1)]
        public int ScheduleReportId { get; init; }
        
        /// <summary>
        /// Report type.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid ReportType { get; init; }

        /// <summary>
        /// Range.
        /// </summary>
        [MessagePack.Key(3)]
        public ReportPresetRange Range { get; init; }

        /// <summary>
        /// Filters.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Filters { get; init; }

        /// <summary>
        /// Preset id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? ReportPresetId { get; init; }
    }
}
