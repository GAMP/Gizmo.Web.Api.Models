namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout group removed", "HOST_LAYOUT_GROUP_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout group removed event", "HOST_LAYOUT_GROUP_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutGroupRemovedEventMessage : HostLayoutGroupEventMessageBase
    {
    }
}
