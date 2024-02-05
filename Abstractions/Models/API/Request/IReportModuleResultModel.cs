namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Report module result model.
    /// </summary>
    public interface IReportModuleResultModel : IWebApiModel
    {
        object ReportModel { get; }

        object? ReportModelAdditional { get; }
    }
}
