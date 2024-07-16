namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Assistance request event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Log", "LOG_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Log related events", "LOG_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(20)]
    public abstract class LogEventMessageBase : APIEventMessage
    {
    }
}
