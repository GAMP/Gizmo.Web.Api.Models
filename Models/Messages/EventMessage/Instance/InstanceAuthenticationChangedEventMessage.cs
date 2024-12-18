using Gizmo.Web.Api.Models;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host layout created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Instance authentication changed", "INSTANCE_AUTHENTICATION_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Instance authentication changed event", "INSTANCE_AUTHENTICATION_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class InstanceAuthenticationChangedEventMessage : InstanceEventMessageBase
    {
    }
}
