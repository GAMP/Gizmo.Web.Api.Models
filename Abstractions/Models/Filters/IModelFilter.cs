namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Filter.
    /// </summary>
    public interface IModelFilter : IModelFilterPagination, IModelFilterOptions, IUriParametersQuery
    {
    }
}
