using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Report pack model.
    /// </summary>
    public interface IReportPackModel : IWebApiModel
    {
        /// <summary>
        /// Report model
        /// </summary>
        object ReportModel { get; }

        /// <summary>
        /// Optional additional report model.
        /// </summary>
        object? ReportModelAdditional { get; }

        /// <summary>
        /// Gets filters metadata.
        /// </summary>
        /// <remarks>
        /// This should contain a list of filters used to generate this report.
        /// </remarks>
        IEnumerable<ReportModuleFilterMetadataModel> FilterMetadata { get; }
    }
}
