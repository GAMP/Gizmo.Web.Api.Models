using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment payment intent model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentPaymentIntentModel : PaymentModel
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

        /// <summary>
        /// Payment id.
        /// </summary>
        /// <remarks>
        /// This value will only be set when the payment intent has been completed and a payment processed.
        /// </remarks>
        [MessagePack.Key(5)]
        public int? PaymentId
        {
            get; init;
        }

        /// <summary>
        /// Payment intent guid.
        /// </summary>
        [MessagePack.Key(6)]
        public Guid Guid { get; init; }
    }
}
