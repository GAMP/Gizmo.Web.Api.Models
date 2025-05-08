namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Cancelled", "RESERVATION_HOST_CANCELLED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host reservation cancelled", "RESERVATION_HOST_CANCELLED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostCancelledEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostCancelledEventMessage() { }

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
