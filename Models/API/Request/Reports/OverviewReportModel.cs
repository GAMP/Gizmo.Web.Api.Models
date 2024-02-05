namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportModel : IWebApiModel
    {
        [MessagePack.Key(0)]
        public int Val => 100;

        [MessagePack.Key(1)]
        public string G { get; set; } = "d4cfbff0-2a91-4af4-90f2-9e92534de3dd";

    }
}
