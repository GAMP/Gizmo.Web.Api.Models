namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Removed", "RESERVATION_USER_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User removed", "RESERVATION_USER_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationUserRemovedEventMessage : ReservationEventMessageBase
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserId { get; init; }
    }
}
