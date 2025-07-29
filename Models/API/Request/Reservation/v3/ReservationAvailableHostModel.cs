using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation available host model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationAvailableHostModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; set; }

        /// <summary>
        /// Host group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostGroupId { get; set; }

        /// <summary>
        /// Reservation status.
        /// </summary>
        [MessagePack.Key(2)]
        public HostReservationAvailabilityStatus Status { get; init; }

        /// <summary>
        /// User group restriction.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsRestricted { get; init; }

        /// <summary>
        /// Current reservation end date.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? EndDate { get; init; }

        /// <summary>
        /// Next reservation date.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime? NextDate { get; init; }
    }
}
