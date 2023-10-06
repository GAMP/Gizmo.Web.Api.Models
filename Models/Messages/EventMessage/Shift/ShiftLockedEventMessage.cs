namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Shift locked event message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftLockedEventMessage : ShiftEventMessageBase
    {
    }
}
