using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UsersFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return users with usernames that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public string Username { get; set; }

        /// <summary>
        /// Return guest users.
        /// </summary>
        [DataMember]
        [MessagePack.Key(202)]
        public bool? IsGuest { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [DataMember]
        [MessagePack.Key(203)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [DataMember]
        [MessagePack.Key(204)]
        public bool? IsDeleted { get; set; }

    }
}
