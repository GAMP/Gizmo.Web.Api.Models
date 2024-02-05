namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Report module result model.
    /// </summary>
    public interface IReportModuleResultModel : IWebApiModel
    {
        /// <summary>
        /// Report model
        /// </summary>
        object ReportModel { get; }

        /// <summary>
        /// Optional additional report model.
        /// </summary>
        object? ReportModelAdditional { get; }
    }
}
