namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation host removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Moved", "RESERVATION_HOST_MOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host moved within reservation", "RESERVATION_HOST_MOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationHostMovedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHostMovedEventMessage() { }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostId
        {
            get;init;
        }

        /// <summary>
        /// Move host id.
        /// </summary>
        [MessagePack.Key(3)]
        public int MoveHostId { get; init; }        
    }
}
