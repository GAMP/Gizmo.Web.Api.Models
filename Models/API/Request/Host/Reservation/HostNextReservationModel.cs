using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host next reservation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostNextReservationModel : IWebApiModel
    {
        /// <summary>
        /// Gets host id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; set; }

        /// <summary>
        /// Gets next reservation id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? NextReservationId { get; set; } = null!;

        /// <summary>
        /// Gets next reservation date.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? NextReservationTime { get; set; } = null!;

        /// <summary>
        /// Gets next reservation duration.
        /// </summary>
        [MessagePack.Key(3)]
        public int? NextReservationDuration { get; set; } = null!;
    }
}
