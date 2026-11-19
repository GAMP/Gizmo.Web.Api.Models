using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of an online payment of a reservation.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationPayResultModel : IWebApiModel
    {
        /// <summary>
        /// Result.
        /// </summary>
        [Key(0)]
        public UserReservationPayResult Result { get; init; }

        /// <summary>
        /// The payment; set when the result is <see cref="UserReservationPayResult.Success"/> or
        /// <see cref="UserReservationPayResult.PaymentInProgress"/>.
        /// </summary>
        [Key(1)]
        public UserPaymentIntentModel? Payment { get; init; }
    }
}
