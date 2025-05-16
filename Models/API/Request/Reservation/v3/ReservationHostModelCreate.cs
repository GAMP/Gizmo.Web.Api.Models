namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation host create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostModelCreate : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Slot.
        /// </summary>
        [MessagePack.Key(1)]
        public int Slot { get; init; }
    }
}
