using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report entry create/update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ScheduleReportEntryCreateUpdateModel : IWebApiModel
    {        
        /// <summary>
        /// Report type.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid ReportType { get; init; }
      
        /// <summary>
        /// Range.
        /// </summary>
        [MessagePack.Key(1)]
        public ReportPresetRange Range { get; init; }

        /// <summary>
        /// Filters.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Filters { get; init; }

        /// <summary>
        /// Preset id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ReportPresetId { get; init; }
    }
}
