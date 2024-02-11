using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class OrdersReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class OrdersReportParametersModel : IWebApiModel , IUriParametersQuery
    {
    }
}
