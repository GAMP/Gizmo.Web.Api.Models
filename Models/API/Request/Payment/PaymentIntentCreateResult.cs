#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Payment
{
    /// <summary>
    /// Payment intent creation result.
    /// </summary>
    [MessagePackObject]
    public sealed class PaymentIntentCreateResult : IPaymentRequestCreateResultApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment intent guid.
        /// </summary>
        [Key(0)]
        public Guid PaymentIntent { get; init; }

        /// <summary>
        /// Gets payment url.
        /// </summary>
        [Key(1)]
        public string PaymentUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets QR Image.
        /// </summary>
        [Key(2)]
        public string? QrImage { get; init; }

        /// <summary>
        /// Native QR Image to be used with payment apps.
        /// </summary>
        /// <remarks>
        /// This value is optional.
        /// </remarks>
        [Key(3)]
        public string? NativeQrImage { get; init; }

        /// <summary>
        /// Gets provider used to create the request.
        /// </summary>
        [Key(4)]
        public Guid Provider { get; init; }

        #endregion
    }
}
