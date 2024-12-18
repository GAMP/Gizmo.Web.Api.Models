using Gizmo.Web.Api.Messaging;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Instance", "INSTANCE_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Instance related events", "INSTANCE_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(22)]
    public abstract class InstanceEventMessageBase : APIEventMessage
    {
    }
}
