using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Club and period of the host availability and host group prices of the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationPeriodFilter : IWebApiModel
    {
        /// <summary>
        /// Branch (club) id.
        /// </summary>
        [Key(0)]
        public int BranchId { get; set; }

        /// <summary>
        /// Reservation start (UTC).
        /// </summary>
        [Key(1)]
        public DateTime Start { get; set; }

        /// <summary>
        /// Duration in minutes.
        /// </summary>
        [Key(2)]
        public int Duration { get; set; }
    }
}
