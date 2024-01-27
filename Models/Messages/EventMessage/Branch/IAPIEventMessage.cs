using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1100, typeof(BranchCreatedEventMessage))]
    [Union(1101, typeof(BranchUpdatedEventMessage))]
    [Union(1102, typeof(BranchDeletedEventMessage))]
    [Union(1103, typeof(BranchUndeletedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
