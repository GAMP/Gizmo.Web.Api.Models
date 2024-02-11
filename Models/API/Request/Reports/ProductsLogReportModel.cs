using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{ 
    [MessagePack.MessagePackObject()]
    public class ProductsLogReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class ProductsLogReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
