using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(100, typeof(UserBalanceChangedUserEventMessage))]
    [Union(101, typeof(UserReservationCreatedUserEventMessage))]
    [Union(102, typeof(UserReservationCancelledUserEventMessage))]
    [Union(103, typeof(NewsChangedUserEventMessage))]
    [Union(104, typeof(UserPaymentCompletedUserEventMessage))]
    [Union(105, typeof(UserPaymentFailedUserEventMessage))]
    public partial interface IUserEventMessage
    {
    }
}
