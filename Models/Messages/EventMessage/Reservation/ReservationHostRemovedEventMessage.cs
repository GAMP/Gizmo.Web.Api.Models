namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Removed", "RESERVATION_HOST_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host removed from an reservation", "RESERVATION_HOST_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostRemovedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostRemovedEventMessage() { }

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
