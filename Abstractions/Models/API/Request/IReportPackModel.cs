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
        /// Gets export metadata.
        /// </summary>
        /// <remarks>
        /// This will contain parameters and filters used to generate this report.
        /// </remarks>
        ReportExportMetadataModel Metadata { get; }
    }
}
