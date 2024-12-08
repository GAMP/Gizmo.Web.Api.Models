using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Schedule report entry.
    /// </summary>
    public interface IScheduleReportEntry
    {
        /// <summary>
        /// Schedule report id.
        /// </summary>
        public int ScheduleReportId { get; init; }

        /// <summary>
        /// Report.
        /// </summary>
        public Guid Report { get; init; }

        /// <summary>
        /// Report range.
        /// </summary>
        public ReportPresetRange Range { get; init; }

        /// <summary>
        /// Report preset id.
        /// </summary>
        public int ReportPresetId { get; init; }
    }
}
