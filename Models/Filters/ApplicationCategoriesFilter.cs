using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application categories.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationCategoriesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return categories with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Return subcategories that belongs to the specified parent category.
        /// </summary>
        /// <remarks>
        /// To return all categories leave this field empty.
        /// To return all parent categories fill this field with 0.
        /// </remarks>
        [Key(201)]
        public int? ParentId { get; set; }
    }
}