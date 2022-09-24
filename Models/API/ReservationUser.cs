using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation User.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ReservationUser
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        #endregion
    }
}
