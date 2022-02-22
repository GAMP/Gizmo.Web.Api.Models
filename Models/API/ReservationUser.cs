using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation User.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class ReservationUser
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        #endregion
    }
}
