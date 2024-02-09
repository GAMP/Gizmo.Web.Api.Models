using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1300, typeof(OptionsChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
