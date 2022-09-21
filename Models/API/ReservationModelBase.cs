using MessagePack;
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
    [MessagePackObject]
    public class ReservationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user this reservation is associated with.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int? UserId { get; set; }

        /// <summary>
        /// The date of the reservation.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The duration of the reservation.
        /// </summary>
        [DataMember]
        [Required]
        [Range(1, int.MaxValue)]
        [MessagePack.Key(2)]
        public int Duration { get; set; }

        /// <summary>
        /// The contact phone of the reservation.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        [MessagePack.Key(3)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// The contact email of the reservation.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        [EmailNullEmptyValidation]
        [MessagePack.Key(4)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// The note of the reservation.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public string Note { get; set; }

        /// <summary>
        /// The pin of the reservation.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6)]
        [MessagePack.Key(6)]
        public string Pin { get; set; }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(7)]
        public ReservationStatus Status { get; set; }

        /// <summary>
        /// The reserved hosts by this reservation.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(8)]
        public IEnumerable<ReservationHost> Hosts { get; set; }

        /// <summary>
        /// The users of this reservation.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public IEnumerable<ReservationUser> Users { get; set; }

        #endregion
    }
}
