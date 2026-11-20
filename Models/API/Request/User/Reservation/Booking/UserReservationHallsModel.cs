using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Halls of a club with the hosts and the host groups needed to pick a host.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHallsModel : IWebApiModel
    {
        /// <summary>
        /// Halls of the club ordered by display order.
        /// </summary>
        [Key(0)]
        public IEnumerable<UserReservationHallModel> Halls { get; init; } = Enumerable.Empty<UserReservationHallModel>();

        /// <summary>
        /// Hosts of the club that can be booked.
        /// </summary>
        [Key(1)]
        public IEnumerable<UserReservationBranchHostModel> Hosts { get; init; } = Enumerable.Empty<UserReservationBranchHostModel>();

        /// <summary>
        /// Host groups of the club hosts.
        /// </summary>
        [Key(2)]
        public IEnumerable<UserReservationHostGroupModel> HostGroups { get; init; } = Enumerable.Empty<UserReservationHostGroupModel>();
    }
}
