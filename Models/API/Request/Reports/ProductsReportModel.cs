using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class ProductsReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class ProductsReportParametersModel : IWebApiModel, IUriParametersQuery
    {

    }
}
