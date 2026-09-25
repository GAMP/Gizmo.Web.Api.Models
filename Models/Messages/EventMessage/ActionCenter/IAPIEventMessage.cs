using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2700, typeof(ActionCenterEntryCreatedEventMessage))]
    [Union(2701, typeof(ActionCenterEntryResolvedEventMessage))]
    [Union(2702, typeof(ActionCenterEntryExpiredEventMessage))]
    [Union(2703, typeof(ActionCenterEntryViewChangedEventMessage))]
    [Union(2704, typeof(ActionCenterEntryCancelledEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
