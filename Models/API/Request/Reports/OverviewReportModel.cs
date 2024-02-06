namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportModel : IWebApiModel
    {
        public int TransactionCount { get; set; }
    }
}
