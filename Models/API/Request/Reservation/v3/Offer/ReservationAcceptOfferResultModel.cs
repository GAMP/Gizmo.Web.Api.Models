using System;

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

        /// <summary>
        /// Optional payment intent.
        /// </summary>
        [MessagePack.Key(3)]
        public Guid? PaymentIntent { get; init; }

        /// <summary>
        /// Optional payment url.
        /// </summary>
        /// <remarks>
        /// This will only have value if payment intent was created by an payment provider and can be used in conjunction with <see cref="PaymentIntent"/>.
        /// </remarks>
        [MessagePack.Key(4)]
        public string? PaymentUrl { get; init; }
    }
}
