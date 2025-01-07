namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Activated", "RESERVATION_HOST_ACTIVATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host added to an reservation", "RESERVATION_HOST_ACTIVATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostActivatedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostActivatedEventMessage() { }

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
