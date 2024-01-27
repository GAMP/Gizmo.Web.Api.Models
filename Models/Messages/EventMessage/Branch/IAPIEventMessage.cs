using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1100, typeof(BranchCreatedEventMessage))]
    [Union(1101, typeof(BranchUpdatedEventMessage))]
    [Union(1102, typeof(BranchDeletedEventMessage))]
    [Union(1103, typeof(BranchUndeletedEventMessage))]
    [Union(1104, typeof(BranchOperatorAddedEventMessage))]
    [Union(1105, typeof(BranchOperatorRemovedEventMessage))]
    [Union(1106, typeof(BranchOperatorDefaultChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
