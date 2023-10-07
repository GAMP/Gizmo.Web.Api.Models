namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Shift unlocked event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Unlocked", "SHIFT_UNLOCKED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates shift unlock", "SHIFT_UNLOCKED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ShiftUnlockedEventMessage : ShiftEventMessageBase
    {
    }
}
