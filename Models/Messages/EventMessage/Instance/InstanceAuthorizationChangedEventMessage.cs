using Gizmo.Web.Api.Models;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Instance authorization changed", "INSTANCE_AUTHORIZATION_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Instance authorization changed event", "INSTANCE_AUTHORIZATION_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class InstanceAuthorizationChangedEventMessage : InstanceEventMessageBase
    {
    }
}
