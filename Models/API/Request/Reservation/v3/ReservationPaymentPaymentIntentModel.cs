using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation payment payment intent model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationPaymentPaymentIntentModel : ReservationPaymentModel
    {
        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Payment creation time.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// Payment intent state.
        /// </summary>
        [MessagePack.Key(3)]
        public PaymentIntentState IntentState { get; init; }

        /// <summary>
        /// Payment url.
        /// </summary>
        [MessagePack.Key(4)]
        public string? PaymentUrl
        {
            get; init;
        }
    }
}
