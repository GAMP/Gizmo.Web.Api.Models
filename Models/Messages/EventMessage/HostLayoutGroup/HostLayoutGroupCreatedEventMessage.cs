namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Host layout group created", "HOST_LAYOUT_GROUP_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Host layout group created event", "HOST_LAYOUT_GROUP_CREATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutGroupCreatedEventMessage : HostLayoutGroupEventMessageBase
    {
    }
}
