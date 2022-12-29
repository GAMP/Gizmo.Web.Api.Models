namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Filters
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    public interface IPaginationFilterModel
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        public PaginationFilter PaginationFilter { get; set; }
    }
}