namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Shift ended event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Ended", "SHIFT_ENDED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates shift end", "SHIFT_ENDED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ShiftEndedEventMessage : ShiftEventMessageBase
    {
    }
}
