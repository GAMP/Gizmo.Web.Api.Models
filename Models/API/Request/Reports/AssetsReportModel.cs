using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class AssetsReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class AssetsReportParametersModel : IWebApiModel , IUriParametersQuery
    {
    }
}
