namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout group event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout group", "HOST_LAYOUT_GROUP_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout group related events", "HOST_LAYOUT_GROUP_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(15)]
    public abstract class HostLayoutGroupEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// Host layout group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostLayoutGroupId { get; set; }
    }
}
