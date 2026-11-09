using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for the reservations of the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationsFilter : IModelFilter<UserReservationModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        /// <remarks>
        /// Limit, cursor and scroll flag are used; the sorting is set by the server according to <see cref="Mode"/>.
        /// </remarks>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result. Not used.
        /// </summary>
        [Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// List mode.
        /// </summary>
        [Key(2)]
        public UserReservationsMode Mode { get; set; } = UserReservationsMode.Current;
    }
}
