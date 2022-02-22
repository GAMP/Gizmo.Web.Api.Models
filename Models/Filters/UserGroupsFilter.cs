using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user groups.
    /// </summary>
    [MessagePackObject]
    public class UserGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return groups with names that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public string GroupName { get; set; }
    }
}
