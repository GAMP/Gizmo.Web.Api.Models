using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2400, typeof(AssetCheckedOutEventMessage))]
    [Union(2401, typeof(AssetCheckedInEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
