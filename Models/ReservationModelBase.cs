using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ReservationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user this reservation is associated with.
        /// </summary>
        [DataMember]
        public int? UserId { get; set; }

        /// <summary>
        /// The date of the reservation.
        /// </summary>
        [DataMember]
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// The duration of the reservation.
        /// </summary>
        [DataMember]
        [Required]
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }

        /// <summary>
        /// The contact phone of the reservation.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// The contact email of the reservation.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        [EmailNullEmpty]
        public string ContactEmail { get; set; }

        /// <summary>
        /// The note of the reservation.
        /// </summary>
        [DataMember]
        public string Note { get; set; }

        /// <summary>
        /// The pin of the reservation.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6)]
        public string Pin { get; set; }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [DataMember]
        public ReservationStatus Status { get; set; }

        /// <summary>
        /// The reserved hosts by this reservation.
        /// </summary>
        [DataMember]
        [Required]
        public IEnumerable<ReservationHost> Hosts { get; set; }

        /// <summary>
        /// The users of this reservation.
        /// </summary>
        [DataMember]
        public IEnumerable<ReservationUser> Users { get; set; }

        #endregion
    }
}
