using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application tasks.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationTasksFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return tasks with names that contain the specified string.
        /// </summary>
        public string TaskName { get; set; }
    }
}
