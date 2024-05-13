namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Filter with classic pagination.
    /// </summary>
    public interface IModelFilterClassic<T> : IModelFilterPaginationClassic, IModelFilterOptions, IUriParametersQuery where T : class, IWebApiModel
    {
    }
}
