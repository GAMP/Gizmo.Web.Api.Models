namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation expired event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Expired", "RESERVATION_EXPIRED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation expired", "RESERVATION_EXPIRED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationExpiredEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationExpiredEventMessage() : base() { }
    }
}
