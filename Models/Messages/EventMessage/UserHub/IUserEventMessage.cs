using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(100, typeof(UserBalanceChangedUserEventMessage))]
    [Union(101, typeof(UserReservationCreatedUserEventMessage))]
    [Union(102, typeof(UserReservationCancelledUserEventMessage))]
    [Union(103, typeof(NewsChangedUserEventMessage))]
    public partial interface IUserEventMessage
    {
    }
}
