using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application categories.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationCategoriesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return categories with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }

        /// <summary>
        /// Return subcategories that belongs to the specified parent category.
        /// </summary>
        /// <remarks>
        /// To return all categories leave this field empty.
        /// To return all parent categories fill this field with 0.
        /// </remarks>
        [DataMember]
        public int? ParentId { get; set; }
    }
}