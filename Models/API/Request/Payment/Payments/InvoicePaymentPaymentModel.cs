using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice payment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoicePaymentPaymentModel : PaymentModel
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

        /// <summary>
        /// Payment id.
        /// </summary>
        [MessagePack.Key(5)]
        public int PaymentId { get; init; }

        /// <summary>
        /// Id.
        /// </summary>
        [MessagePack.Key(6)]
        public int Id { get; set; }
    }
}
