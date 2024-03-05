namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout", "HOST_LAYOUT_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout related events", "HOST_LAYOUT_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(14)]
    public abstract class HostLayoutEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// Host layout group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostLayoutGroupId { get; init; }
    }
}
