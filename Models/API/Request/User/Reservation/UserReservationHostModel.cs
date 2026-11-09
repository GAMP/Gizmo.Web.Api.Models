using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host of the reservation of the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHostModel : IWebApiModel
    {
        /// <summary>
        /// Host number.
        /// </summary>
        [Key(0)]
        public int HostNumber { get; init; }

        /// <summary>
        /// Host name.
        /// </summary>
        [Key(1)]
        public string HostName { get; init; } = string.Empty;

        /// <summary>
        /// Name of the host group (zone); null when the host has no group.
        /// </summary>
        [Key(2)]
        public string? HostGroupName { get; init; }

        /// <summary>
        /// Status of the host reservation.
        /// </summary>
        [Key(3)]
        public ReservationHostStatus Status { get; init; }
    }
}
