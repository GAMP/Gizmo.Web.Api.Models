using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for host groups.
    /// </summary>
    [MessagePackObject]
    public class HostGroupsFilter : PaginationFilter, IUrlQueryParameters
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
