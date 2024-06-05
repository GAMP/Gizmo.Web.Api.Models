using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(400, typeof(WaitingLineUserAddedEventMessage))]
    [Union(401, typeof(WaitingLineUserMoveEventMessage))]
    [Union(402, typeof(WaitingLineUserRemovedEventMessage))]
    [Union(403, typeof(WaitingLineEstimationChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
