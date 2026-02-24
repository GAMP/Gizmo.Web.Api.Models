
namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client reservation payments create result.
    /// </summary>
    public enum ClientReservationCreateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Some of the parameters are invalid.
        /// </summary>
        InvalidParameters = 1,

        /// <summary>
        /// Internal error.
        /// </summary>
        Error = 2,

        /// <summary>
        /// Another payment intent is already in progress with a different payment method.
        /// </summary>
        PaymentIntentInProgress = 3,
    }
}
