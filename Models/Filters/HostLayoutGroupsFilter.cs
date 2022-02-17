using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for host layout groups.
    /// </summary>
    public class HostLayoutGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return layout groups with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string LayoutGroupName { get; set; }
    }
}
