#nullable enable

using MessagePack;

namespace Gizmo.Web.Api.Models
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
        [Key(0)]
        public int HostId { get; set; }

        #endregion
    }
}
