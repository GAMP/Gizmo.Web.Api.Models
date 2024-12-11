using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2100, typeof(BarcodeScannedEventMessage))]
    [Union(2101, typeof(SmartCardReaderDataEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
