using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2500, typeof(UserMaintenceErrorEventMessage))]
    [Union(2501, typeof(UserFixDuplicatesResultEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
