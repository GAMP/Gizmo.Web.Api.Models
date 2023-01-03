#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation User.
    /// </summary>
    [MessagePackObject]
    public sealed class ReservationUser
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        #endregion
    }
}
