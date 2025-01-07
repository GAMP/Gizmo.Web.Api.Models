namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Completed", "RESERVATION_HOST_COMPLETED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host added to an reservation", "RESERVATION_HOST_COMPLETED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostCompletedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostCompletedEventMessage() { }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostId
        {
            get;init;
        }
    }
}
