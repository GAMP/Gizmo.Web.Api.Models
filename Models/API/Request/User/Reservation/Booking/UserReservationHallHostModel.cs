using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Layout position of a host in a hall.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHallHostModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Layout row.
        /// </summary>
        [Key(1)]
        public int Row { get; init; }

        /// <summary>
        /// Layout column.
        /// </summary>
        [Key(2)]
        public int Column { get; init; }
    }
}
