#nullable enable

using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for users.
    /// </summary>
    [MessagePackObject]
    public sealed class UsersFilter : IFilterApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; } = new();

        /// <summary>
        /// Return users of the specified user group.
        /// </summary>
        [Key(1)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Return users with usernames that contain the specified string.
        /// </summary>
        [Key(2)]
        public string Username { get; set; } = null!;

        /// <summary>
        /// Smart card UID.
        /// </summary>
        [Key(3)]
        [System.ComponentModel.DataAnnotations.MaxLength(255)]
        public string SmartCardUID { get; set; } = null!;

        /// <summary>
        /// Return guest users.
        /// </summary>
        [Key(4)]
        public bool? IsGuest { get; set; }

        /// <summary>
        /// Return disabled users.
        /// </summary>
        [Key(5)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted users.
        /// </summary>
        [Key(6)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(7)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
