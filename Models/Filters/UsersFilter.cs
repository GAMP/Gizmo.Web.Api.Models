using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UsersFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [Key(200)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return users with usernames that contain the specified string.
        /// </summary>
        [Key(201)]
        public string Username { get; set; }

        /// <summary>
        /// Smart card UID.
        /// </summary>
        [Key(205)]
        [System.ComponentModel.DataAnnotations.MaxLength(255)]
        public string SmartCardUID
        {
            get; set;
        }

        /// <summary>
        /// Return guest users.
        /// </summary>
        [Key(202)]
        public bool? IsGuest { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [Key(203)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [Key(204)]
        public bool? IsDeleted { get; set; }    

        #endregion

    }
}
