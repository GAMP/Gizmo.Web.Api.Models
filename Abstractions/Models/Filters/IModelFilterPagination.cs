namespace Gizmo.Web.Api.Models.Abstractions.Models.Filters
{
    /// <summary>
    /// Filter for cursor-based pagination.
    /// </summary>
    public interface IModelFilterPagination
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        public ModelFilterPagination Pagination { get; set; }
    }
}