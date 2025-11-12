using Gizmo.Web.Api.Models;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation payment status changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Payment status changed", "RESERVATION_PAYMENT_STATUS_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Reservation payment status changed", "RESERVATION_PAYMENT_STATUS_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReservationPaymentStatusChangedEvent : ReservationEventMessageBase
    {
        /// <summary>
        /// New payment status.
        /// </summary>
        [MessagePack.Key(2)]
        public ReservationPaymentStatus Status { get; set; }
    }
}
