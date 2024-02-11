using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class InvoicesReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class InvoicesReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
