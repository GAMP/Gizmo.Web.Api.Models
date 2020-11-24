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
        [DataMember(EmitDefaultValue = false)]
        public int? UserGroupId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsDeleted { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsDisabled { get; set; }
    }
}