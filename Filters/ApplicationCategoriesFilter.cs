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
        /// Gets
        /// </summary>
        [DataMember]
        public int? ParentId { get; set; }
    }
}