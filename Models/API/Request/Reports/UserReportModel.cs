using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class UserReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class UserReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
