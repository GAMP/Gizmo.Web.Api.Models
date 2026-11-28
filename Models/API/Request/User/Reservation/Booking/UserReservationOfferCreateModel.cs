using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request of a reservation offer for the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationOfferCreateModel : IWebApiModel
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
        public DateTime Date { get; set; }

        /// <summary>
        /// Duration in minutes.
        /// </summary>
        [Key(2)]
        public int Duration { get; set; }

        /// <summary>
        /// Ids of the hosts to book.
        /// </summary>
        [Key(3)]
        public List<int> Hosts { get; set; } = new();
    }
}
