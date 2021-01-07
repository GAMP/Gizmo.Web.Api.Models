﻿using System;
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

        [DataMember]
        [Required]
        public IEnumerable<ReservationHost> Hosts { get; set; }

        [DataMember]
        public IEnumerable<ReservationUser> Users { get; set; }

        #endregion
    }
}
