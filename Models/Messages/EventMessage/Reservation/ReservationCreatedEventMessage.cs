using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Created", "RESERVATION_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation created", "RESERVATION_CREATED_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class ReservationCreatedEventMessage : ReservationEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationCreatedEventMessage() : base()
        { }
        #endregion
    }
}
