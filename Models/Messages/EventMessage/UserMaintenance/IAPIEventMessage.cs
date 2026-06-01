using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2500, typeof(UserMaintenceErrorEventMessage))]
    [Union(2501, typeof(FixUsersResultEventMessage))]
    [Union(2502, typeof(ImportUsersResultEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
