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
    public class ReservationsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return reservations where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return reservations where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return reservations with the specified reservation status.
        /// </summary>
        [DataMember]
        [EnumValue]
        public ReservationStatus? Status { get; set; }

        /// <summary>
        /// Return reservations of the specified user.
        /// </summary>
        [DataMember]
        public int? UserId { get; set; }

        /// <summary>
        /// Return reservations with the specified contact phone.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Return reservations with the specified contact email.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        public string ContactEmail { get; set; }

    }
}
