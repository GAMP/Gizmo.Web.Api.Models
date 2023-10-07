namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Shift stared event message.
    /// </summary>    
    [System.ComponentModel.DataAnnotations.Name("Started", "SHIFT_STARTED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates shift start", "SHIFT_STARTED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ShiftStartedEventMessage : ShiftEventMessageBase
    {
    }
}
