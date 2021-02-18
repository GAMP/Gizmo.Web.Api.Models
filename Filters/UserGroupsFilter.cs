using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user groups.
    /// </summary>
    public class UserGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return groups with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string GroupName { get; set; }
    }
}
