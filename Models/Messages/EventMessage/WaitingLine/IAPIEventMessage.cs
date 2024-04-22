using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(400, typeof(WaitingLineUserAddedEventMessage))]
    [Union(401, typeof(WaitingLineUserRemovedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
