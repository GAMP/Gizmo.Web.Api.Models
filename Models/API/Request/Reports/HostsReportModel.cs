using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class HostsReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class HostsReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
