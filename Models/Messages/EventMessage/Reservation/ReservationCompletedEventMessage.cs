using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Completed", "RESERVATION_COMPLETED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation completed event", "RESERVATION_COMPLETED_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class ReservationCompletedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationCompletedEventMessage():base() { }
    }
}
