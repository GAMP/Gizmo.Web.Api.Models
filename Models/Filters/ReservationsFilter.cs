using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for reservations.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ReservationsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return reservations where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return reservations where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return reservations with the specified reservation status.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(202)]
        public ReservationStatus? Status { get; set; }

        /// <summary>
        /// Return reservations of the specified user.
        /// </summary>
        [DataMember]
        [MessagePack.Key(203)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return reservations with the specified contact phone.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        [MessagePack.Key(204)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Return reservations with the specified contact email.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        [MessagePack.Key(205)]
        public string ContactEmail { get; set; }

    }
}
