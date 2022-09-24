using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation Host.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ReservationHost
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int HostId { get; set; }

        #endregion
    }
}
