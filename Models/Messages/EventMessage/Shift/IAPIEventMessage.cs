using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1000, typeof(ShiftStartedEventMessage))]
    [Union(1001, typeof(ShiftEndedEventMessage))]
    [Union(1002, typeof(ShiftLockedEventMessage))]
    [Union(1003, typeof(ShiftUnlockedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
