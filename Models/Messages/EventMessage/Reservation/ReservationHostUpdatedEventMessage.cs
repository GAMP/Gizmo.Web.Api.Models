namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Updated", "RESERVATION_HOST_UPDATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host reservation updated", "RESERVATION_HOST_UPDATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostUpdatedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostUpdatedEventMessage() { }

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
