using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1200, typeof(ReportPresetAddedEventMessage))]
    [Union(1201, typeof(ReportPresetUpdatedEventMessage))]
    [Union(1202, typeof(ReportPresetRemoveEventMessage))]
    [Union(1203, typeof(ReportPresetDisplayOrderChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
