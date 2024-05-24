using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Cancelled", "RESERVATION_CANCELLED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation cancelled", "RESERVATION_CANCELLED_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class ReservationCancelledEventMessage : ReservationEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationCancelledEventMessage() : base()
        { }
        #endregion
    }
}
