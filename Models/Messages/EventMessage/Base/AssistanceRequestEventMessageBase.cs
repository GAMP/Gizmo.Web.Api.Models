namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Assistance request event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Assistance request", "ASSISTANCE_REQUEST_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Assistance request related events", "ASSISTANCE_REQUEST_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(9)]
    public abstract class AssistanceRequestEventMessageBase : APIEventMessage
    {
    }
}
