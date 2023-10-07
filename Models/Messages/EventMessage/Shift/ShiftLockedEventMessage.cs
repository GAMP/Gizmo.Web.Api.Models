namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Shift locked event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Locked", "SHIFT_LOCKED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates shift lock", "SHIFT_LOCKED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ShiftLockedEventMessage : ShiftEventMessageBase
    {
    }
}
