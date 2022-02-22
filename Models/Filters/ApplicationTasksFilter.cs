using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application tasks.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationTasksFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return tasks with names that contain the specified string.
        /// </summary>
        [MessagePack.Key(200)]
        public string TaskName { get; set; }
    }
}
