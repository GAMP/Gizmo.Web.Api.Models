namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation activated event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Activated", "RESERVATION_ACTIVATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation activated event", "RESERVATION_ACTIVATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationActivatedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationActivatedEventMessage() : base() { }
    }
}
