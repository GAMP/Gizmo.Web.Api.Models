namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation expired event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Expired", "RESERVATION_ACTIVATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation expired event", "RESERVATION_ACTIVATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationExpiredEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationExpiredEventMessage() : base() { }
    }
}
