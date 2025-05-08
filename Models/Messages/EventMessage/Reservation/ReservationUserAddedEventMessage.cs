namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Added", "RESERVATION_USER_ADDED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User added", "RESERVATION_USER_ADDED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationUserAddedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; init; }
    }
}
