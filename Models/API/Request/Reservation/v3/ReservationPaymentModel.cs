using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation payment model.
    /// </summary>
    [MessagePack.Union((int)ReservationPaymentType.InvoicePayment, typeof(ReservationInvoicePaymentModel))]
    [MessagePack.Union((int)ReservationPaymentType.IntentPayment, typeof(ReservationPaymentPaymentIntentModel))]
    [MessagePack.MessagePackObject()]
    public abstract class ReservationPaymentModel : IWebApiModel
    {
    }

    /// <summary>
    /// Reservation payment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationInvoicePaymentModel : ReservationPaymentModel
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
        /// Payment refund status.
        /// </summary>
        /// <remarks>
        /// This will provide information regarding any refund made on the payment.
        /// </remarks>
        [MessagePack.Key(3)]
        public RefundStatus RefundStatus { get; init; }

        /// <summary>
        /// Refunded amount.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal RefundedAmount { get; init; }
    }

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
