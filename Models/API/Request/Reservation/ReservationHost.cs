using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Reservation
{
    /// <summary>
    /// Reservation Host.
    /// </summary>
    [MessagePackObject]
    public sealed class ReservationHost
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the host.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; set; }

        #endregion
    }
}
