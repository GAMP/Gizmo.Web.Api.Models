using System;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Payment request creation result.
    /// </summary>
    public interface IPaymentRequestCreateResultApiModel
    {
        /// <summary>
        /// Native QR Image to be used with payment apps.
        /// </summary>
        /// <remarks>
        /// This value is optional.
        /// </remarks>
        string NativeQrImage { get; init; }

        /// <summary>
        /// Gets payment url.
        /// </summary>
        string PaymentUrl { get; init; }

        /// <summary>
        /// Gets provider used to create the request.
        /// </summary>
        Guid Provider { get; init; }

        /// <summary>
        /// Gets QR Image.
        /// </summary>
        string QrImage { get; init; }
    }
}