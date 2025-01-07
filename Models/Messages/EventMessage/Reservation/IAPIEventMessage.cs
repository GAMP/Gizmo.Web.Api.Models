using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(600, typeof(ReservationCreatedEventMessage))]
    [Union(601, typeof(ReservationUpdatedEventMessage))]
    [Union(602, typeof(ReservationCancelledEventMessage))]
    [Union(603, typeof(ReservationHostAddedEventMessage))]
    [Union(604, typeof(ReservationHostUpdatedEventMessage))]
    [Union(605, typeof(ReservationHostRemovedEventMessage))]
    [Union(606, typeof(ReservationActivatedEventMessage))]
    [Union(607, typeof(ReservationCompletedEventMessage))]
    [Union(608, typeof(ReservationExpiredEventMessage))]

    [Union(609, typeof(ReservationHostActivatedEventMessage))]
    [Union(610, typeof(ReservationHostCancelledEventMessage))]
    [Union(611, typeof(ReservationHostCompletedEventMessage))]
    [Union(612, typeof(ReservationHostExpiredEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
