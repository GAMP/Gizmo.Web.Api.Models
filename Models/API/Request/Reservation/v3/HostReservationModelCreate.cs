using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostReservationModelCreate : IWebApiModel
    {
        /// <summary>
        /// Reserving user id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; init; }

        /// <summary>
        /// Contact phone.
        /// </summary>
        [StringLength(20)]
        [PhoneNullEmptyValidation()]
        [MessagePack.Key(1)]
        public string? ContactPhone { get; init; }

        /// <summary>
        /// Contact email.
        /// </summary>
        [StringLength(254)]
        [EmailNullEmptyValidation]
        [MessagePack.Key(2)]
        public string? ContactEmail { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Note { get; init; }

        /// <summary>
        /// Reservation date.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime Date { get; init; }

        /// <summary>
        /// Reservation duration.
        /// </summary>
        [MessagePack.Key(5)]
        public int Duration { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(6)]
        public int BranchId { get; init; }

        /// <summary>
        /// Reservation hosts.
        /// </summary>
        [MessagePack.Key(7)]
        public IEnumerable<ReservationHostModelCreate> Hosts { get; set; } = Enumerable.Empty<ReservationHostModelCreate>();

        /// <summary>
        /// Reservation users.
        /// </summary>
        [MessagePack.Key(8)]
        public IEnumerable<ReservationUserModelCreate> Users { get; set; } = Enumerable.Empty<ReservationUserModelCreate>();
    }
}
