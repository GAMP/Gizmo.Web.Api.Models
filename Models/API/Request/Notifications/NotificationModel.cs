namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Notification model.
    /// </summary>
    [MessagePack.Union((int)NotificationTypes.TimeRemaining, typeof(NotificationTimedRemainingModel))]
    [MessagePack.Union((int)NotificationTypes.Reservation, typeof(NotificationTimedReservationModel))]
    [MessagePack.MessagePackObject()]
    public abstract class NotificationModel : IWebApiModel
    {
    }
}
