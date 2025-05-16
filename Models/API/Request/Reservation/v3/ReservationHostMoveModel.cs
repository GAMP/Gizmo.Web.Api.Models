namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation host move model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostMoveModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Move host id.
        /// </summary>
        [MessagePack.Key(1)]
        public int MoveHostId { get; init; }
    }
}
