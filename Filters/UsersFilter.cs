using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [Serializable]
    [DataContract]
    public class UsersFilter : PaginationFilter , IUrlQueryParameters
    {
        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [DataMember]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return users with usernames that contain the specified string.
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [DataMember]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [DataMember]
        public bool? IsDeleted { get; set; }

    }
}
