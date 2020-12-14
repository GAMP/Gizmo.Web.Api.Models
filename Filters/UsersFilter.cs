using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [Serializable]
    [DataContract]
    public class UsersFilter : PaginationFilter
    {
        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? IsDeleted { get; set; }

    }
}