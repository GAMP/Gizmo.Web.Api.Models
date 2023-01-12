using Gizmo.Web.Api.Models.Abstractions.Models.RequestParameters;

namespace Gizmo.Web.Api.Models.Abstractions.Models.Filters
{
    /// <summary>
    /// Filter.
    /// </summary>
    public interface IModelFilter : IModelFilterPagination, IModelFIlterOptions, IUrlQueryParameters, IRequestParametersQuery
    {
    }
}