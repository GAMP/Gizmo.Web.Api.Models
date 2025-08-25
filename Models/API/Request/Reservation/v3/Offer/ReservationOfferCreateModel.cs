using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host reservation offer creation model.
    /// </summary>
    /// <remarks>
    /// Used as parameters for creating reservation offers for an set of hosts.<br></br>
    /// <b>One of <see cref="UserId"/> or <see cref="UserGroupId"/> must be specified, not doing so will result in reservation error.</b>
    /// </remarks>

    [MessagePack.MessagePackObject]
    public sealed class ReservationOfferCreateModel : IWebApiModel , IUriParametersQuery
    {
        /// <summary>
        /// Reservation start date.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Duration of the reservation in minutes.
        /// </summary>
        [Required()]
        [Range(0, int.MaxValue)]
        [MessagePack.Key(1)]
        public int Duration { get; set; }

        /// <summary>
        /// Participating hosts.
        /// </summary>
        /// <remarks>
        /// List of host's for reservation.
        /// </remarks>
        [Required()]
        [MessagePack.Key(2)]
        public List<int> Hosts { get; set; } = [];

        /// <summary>
        /// Reserving user group id.
        /// </summary>
        /// <remarks>
        /// Specifies the user group making the reservation.<br></br><b>This value cannot be set and will result in error in case <see cref="UserId"/> is specified</b>.
        /// </remarks>
        [MessagePack.Key(3)]
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Reserving user id.
        /// </summary>
        /// <remarks>
        /// Specifies the user making the reservation.<br></br><b>This value cannot be set and will result in error in case <see cref="UserGroupId"/> is specified</b>.
        /// </remarks>
        [MessagePack.Key(4)]
        public int? UserId { get; set; }

        /// <summary>
        /// Reservation users.
        /// </summary>
        [MessagePack.Key(5)]
        public List<int> Users { get; set; } = [];

        /// <summary>
        /// Reservation note.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(6)]
        public string? Note { get; set; }
    }
}
