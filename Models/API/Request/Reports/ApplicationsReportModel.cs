using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationsReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class ApplicationsReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
