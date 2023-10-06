using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1000, typeof(ShiftStartedEventMessage))]
    [Union(1001, typeof(ShiftEndedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
