using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2600, typeof(ActionCenterEntryCreatedEventMessage))]
    [Union(2601, typeof(ActionCenterEntryResolvedEventMessage))]
    [Union(2602, typeof(ActionCenterEntryExpiredEventMessage))]
    [Union(2603, typeof(ActionCenterEntryViewChangedEventMessage))]
    [Union(2604, typeof(ActionCenterEntryCancelledEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
