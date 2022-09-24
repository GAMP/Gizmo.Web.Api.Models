using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application tasks.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationTasksFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return tasks with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string TaskName { get; set; } 

        #endregion
    }
}
