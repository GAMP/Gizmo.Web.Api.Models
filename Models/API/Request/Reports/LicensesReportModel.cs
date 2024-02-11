using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class LicensesReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class LicensesReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
