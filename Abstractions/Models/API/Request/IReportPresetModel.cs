using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Report preset model.
    /// </summary>
    public interface IReportPresetModel : IWebApiModel
    {
        /// <summary>
        /// Preset name. 
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Preset report.
        /// </summary>
        public Guid Report { get; init; }

        /// <summary>
        /// Preset filters.
        /// </summary>
        public string? Filters { get; init; }

        /// <summary>
        /// Preset range.
        /// </summary>
        public ReportPresetRange Range { get; init; }

        /// <summary>
        /// Preset display order.
        /// </summary>
        public int DisplayOrder { get; init; }
    }
}
