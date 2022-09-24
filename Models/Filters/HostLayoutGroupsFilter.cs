using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for host layout groups.
    /// </summary>
    [MessagePackObject]
    public class HostLayoutGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return layout groups with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string LayoutGroupName { get; set; } 

        #endregion
    }
}
