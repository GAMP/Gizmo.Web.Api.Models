using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application groups.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return groups with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string GroupName { get; set; } 

        #endregion
    }
}