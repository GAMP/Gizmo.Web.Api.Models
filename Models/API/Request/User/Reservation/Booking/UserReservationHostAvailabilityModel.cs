using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Availability of a host for the period and the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHostAvailabilityModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Whether the host is free for the period and the current user can book it.
        /// </summary>
        [Key(1)]
        public bool IsAvailable { get; init; }
    }
}
