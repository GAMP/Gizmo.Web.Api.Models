using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for reservations.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ReservationsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return reservations where the date greater than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return reservations where the date less than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return reservations with the specified reservation status.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(202)]
        public ReservationStatus? Status { get; set; }

        /// <summary>
        /// Return reservations of the specified user.
        /// </summary>
        [MessagePack.Key(203)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return reservations with the specified contact phone.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(204)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Return reservations with the specified contact email.
        /// </summary>
        [StringLength(254)]
        [MessagePack.Key(205)]
        public string ContactEmail { get; set; } 

        #endregion

    }
}
