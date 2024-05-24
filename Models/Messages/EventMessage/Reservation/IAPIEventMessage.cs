using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(600, typeof(ReservationCreatedEventMessage))]
    [Union(601, typeof(ReservationUpdatedEventMessage))]
    [Union(602, typeof(ReservationCancelledEventMessage))]
    [Union(603, typeof(ReservationHostAddedEventMessage))]
    [Union(604, typeof(ReservationHostReservationUpdatedEventMessage))]
    [Union(605, typeof(ReservationHostRemovedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
