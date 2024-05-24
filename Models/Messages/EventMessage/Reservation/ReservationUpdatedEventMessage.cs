namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Updated", "RESERVATION_UPDATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation updated", "RESERVATION_UPDATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationUpdatedEventMessage : ReservationEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationUpdatedEventMessage() : base()
        { }
        #endregion
    }
}
