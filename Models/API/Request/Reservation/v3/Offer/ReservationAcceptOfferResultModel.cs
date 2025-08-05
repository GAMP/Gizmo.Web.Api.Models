namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation offer accept result model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ReservationAcceptOfferResultModel : CreateResult
    {
        /// <summary>
        /// Reservation pin.
        /// </summary>
        [MessagePack.Key(1)]
        public string Pin { get; init; } = null!;

        /// <summary>
        /// Reservation payment status.
        /// </summary>
        [MessagePack.Key(2)]
        public ReservationPaymentStatus PaymentStatus { get; init; }
    }
}
