namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Assistance request creation event.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Created", "ASSISTANCE_REQUEST_CREATED_EVENT_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates assistance request creation","ASSISTANCE_REQUEST_CREATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestCreatedMessage : AssistanceRequestEventMessageBase
    {
        /// <summary>
        /// Gets request id.
        /// </summary>
        [MessagePack.Key(3)]
        public int AssistanceRequestId { get; init; }

        /// <summary>
        /// Gets request type id.
        /// </summary>
        [MessagePack.Key(4)]
        public int AssistanceRequestTypeId { get; init; }
    }
}
