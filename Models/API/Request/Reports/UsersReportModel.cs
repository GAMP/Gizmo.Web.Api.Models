using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class UsersReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class UsersReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
