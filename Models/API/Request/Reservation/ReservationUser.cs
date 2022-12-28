using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Reservation
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
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        #endregion
    }
}
