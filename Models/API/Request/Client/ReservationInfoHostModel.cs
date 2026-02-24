namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation info host model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationInfoHostModel : IWebApiModel
    {
        /// <summary>
        /// Host number.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostNumber { get; init; }

        /// <summary>
        /// Host name.
        /// </summary>
        [MessagePack.Key(1)]
        public required string HostName { get; init; }
    }
}
