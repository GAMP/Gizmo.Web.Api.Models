namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IScheduleModel"/>
    [MessagePack.Union((int)ScheduleTypes.Report, typeof(ScheduleReportModel))]
    [MessagePack.MessagePackObject]
    public abstract class ScheduleModel : IWebApiModel
    {
    }
}
