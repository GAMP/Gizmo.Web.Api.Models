using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application categories.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationCategoriesFilter : IFilterModel
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return categories with names that contain the specified string.
        /// </summary>
        [Key(1)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Return subcategories that belongs to the specified parent category.
        /// </summary>
        /// <remarks>
        /// To return all categories leave this field empty.
        /// To return all parent categories fill this field with 0.
        /// </remarks>
        [Key(2)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(3)]
        public List<string> Expand { get; set; }
    }
}