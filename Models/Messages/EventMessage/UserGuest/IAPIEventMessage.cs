using Gizmo.Web.Api.Models;
using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2300, typeof(UserGuestReservedEventMessage))]
    [Union(2301, typeof(UserGuestReleasedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
