using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation Host.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ReservationHost
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host.
        /// </summary>
        [DataMember]
        [Required]
        public int HostId { get; set; }

        #endregion
    }
}
