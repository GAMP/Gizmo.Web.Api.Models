namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Expired", "RESERVATION_HOST_EXPIRED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host reservation expired event", "RESERVATION_HOST_EXPIRED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostExpiredEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostExpiredEventMessage() { }

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
