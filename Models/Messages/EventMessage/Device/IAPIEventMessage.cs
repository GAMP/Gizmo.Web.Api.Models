using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2100, typeof(BarcodeScannedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
