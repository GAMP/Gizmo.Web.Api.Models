using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client reservation payments create result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientReservationPaymentsCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Invalid parameters result.
        /// </summary>
        public static readonly ClientReservationPaymentsCreateResultModel InvalidParameters = new()
        {
            Payments = Enumerable.Empty<AcceptedOrderPaymentModel>(),
            ExpectedPayment = null,
            Result = ClientReservationCreateResult.InvalidParameters
        };

        /// <summary>
        /// Internal error result.
        /// </summary>
        public static readonly ClientReservationPaymentsCreateResultModel Error = new()
        {
            Payments = Enumerable.Empty<AcceptedOrderPaymentModel>(),
            ExpectedPayment = null,
            Result = ClientReservationCreateResult.Error
        };

        /// <summary>
        /// Empty success result.
        /// </summary>
        public static readonly ClientReservationPaymentsCreateResultModel Success = new()
        {
            Payments = Enumerable.Empty<AcceptedOrderPaymentModel>(),
            ExpectedPayment = null,
            Result = ClientReservationCreateResult.Success
        };

        /// <summary>
        /// Payment intent already in progress with a different payment method.
        /// </summary>
        public static readonly ClientReservationPaymentsCreateResultModel PaymentIntentInProgress = new()
        {
            Payments = Enumerable.Empty<AcceptedOrderPaymentModel>(),
            ExpectedPayment = null,
            Result = ClientReservationCreateResult.PaymentIntentInProgress
        };

        /// <summary>
        /// Result.
        /// </summary>
        [MessagePack.Key(0)]
        public ClientReservationCreateResult Result { get; init; }

        /// <summary>
        /// Created payments.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<AcceptedOrderPaymentModel> Payments { get; set; } = Enumerable.Empty<AcceptedOrderPaymentModel>();

        /// <summary>
        /// Expected payment model if there is expected payment.
        /// </summary>
        [MessagePack.Key(2)]
        public ClientReservationExpectedPaymentModel? ExpectedPayment
        {
            get; init;
        }

    }

    /// <summary>
    /// Client reservation expected payment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientReservationExpectedPaymentModel : IWebApiModel
    {
        /// <summary>
        /// Expected payment amount.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Expected payment method id.
        /// </summary>
        [MessagePack.Key(1)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Expiration time.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? ExpirationTime { get; init; }

        /// <summary>
        /// Payment url.
        /// </summary>
        [MessagePack.Key(3)]
        public required string PaymentUrl { get; init; }
    }

   
}
