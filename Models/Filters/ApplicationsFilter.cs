using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for applications.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return applications with titles that contain the specified string.
        /// </summary>
        [DataMember]
        public string ApplicationTitle { get; set; }

        /// <summary>
        /// Return applications that belongs to the specified category.
        /// </summary>
        [DataMember]
        public int? CategoryId { get; set; }
    }
}
