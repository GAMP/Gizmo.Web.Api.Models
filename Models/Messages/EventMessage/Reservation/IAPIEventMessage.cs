using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(600, typeof(ReservationCreatedEventMessage))]
    [Union(601, typeof(ReservationUpdatedEventMessage))]
    [Union(602, typeof(ReservationCancelledEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
