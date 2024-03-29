using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1600, typeof(ProductStockChangeEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
