using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersFilter : IFilterModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [Key(2)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return users with usernames that contain the specified string.
        /// </summary>
        [Key(3)]
        public string Username { get; set; }

        /// <summary>
        /// Smart card UID.
        /// </summary>
        [Key(4)]
        [System.ComponentModel.DataAnnotations.MaxLength(255)]
        public string SmartCardUID { get; set; }

        /// <summary>
        /// Return guest users.
        /// </summary>
        [Key(5)]
        public bool? IsGuest { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [Key(6)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [Key(7)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(8)]
        public List<string> Expand { get; set; }

        #endregion
    }
}
