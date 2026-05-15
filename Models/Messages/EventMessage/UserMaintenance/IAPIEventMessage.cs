using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2500, typeof(UserMaintenceErrorEventMessage))]
    [Union(2501, typeof(UserFixDuplicatesResultEventMessage))]
    [Union(2502, typeof(UserImportUsersResultEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
