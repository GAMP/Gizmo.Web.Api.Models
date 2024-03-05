namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout updated event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout group updated", "HOST_LAYOUT_GROUP_UPDATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout group updated event", "HOST_LAYOUT_GROUP_UPDATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutGroupUpdatedEventMessage : HostLayoutGroupEventMessageBase
    {
    }
}
