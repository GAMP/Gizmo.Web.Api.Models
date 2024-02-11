using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class StockReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class StockReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
