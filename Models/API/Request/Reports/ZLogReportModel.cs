using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class ZLogReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class ZLogReportParametersModel : IWebApiModel , IUriParametersQuery
    {
        
    }
}
