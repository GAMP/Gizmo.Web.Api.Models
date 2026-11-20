using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Hall of a club with the layout positions of its hosts.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHallModel : IWebApiModel
    {
        /// <summary>
        /// Hall id.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Hall name.
        /// </summary>
        [Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Display order.
        /// </summary>
        [Key(2)]
        public int DisplayOrder { get; init; }

        /// <summary>
        /// Hosts of the hall with their layout positions, hidden entries excluded.
        /// </summary>
        [Key(3)]
        public IEnumerable<UserReservationHallHostModel> Hosts { get; init; } = Enumerable.Empty<UserReservationHallHostModel>();
    }
}
