using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User reservation created event message. Sent to the reservation owner and members.
    /// </summary>
    [MessagePackObject()]
    public sealed class UserReservationCreatedUserEventMessage : UserEventMessage
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserReservationCreatedUserEventMessage() : base()
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
