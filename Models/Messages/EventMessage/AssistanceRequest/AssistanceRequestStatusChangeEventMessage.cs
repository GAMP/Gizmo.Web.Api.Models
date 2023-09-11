namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Assistance request status change event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Change", "ASSISTANCE_REQUEST_CHANGE_EVENT_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates assistance request status change", "ASSISTANCE_REQUEST_CHANGE_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestStatusChangeEventMessage : AssistanceRequestEventMessageBase
    {
        /// <summary>
        /// Gets request id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AssistanceRequestId { get; init; }

        /// <summary>
        /// Gets request new status.
        /// </summary>
        [MessagePack.Key(1)]
        public AssistanceRequestStatus Status { get; init; }
    }
}
