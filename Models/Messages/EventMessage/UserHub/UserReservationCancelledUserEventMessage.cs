using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User reservation cancelled event message. Sent to the reservation owner and members.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserReservationCancelledUserEventMessage : UserEventMessage
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserReservationCancelledUserEventMessage() : base()
        { }

        /// <summary>
        /// Gets reservation id.
        /// </summary>
        [Key(1)]
        public int ReservationId
        {
            get; init;
        }
    }
}
