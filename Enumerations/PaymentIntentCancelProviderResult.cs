namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent cancel result codes.
    /// </summary>
    public enum PaymentIntentCancelProviderResult
    {
        /// <summary>
        /// Not required.
        /// </summary>
        NotRequired = 0,

        /// <summary>
        /// Success.
        /// </summary>
        Success = 1,

        /// <summary>
        /// Provider Error.
        /// </summary>
        ProviderError = 2,

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <remarks>
        /// Provider does not support canceling payment intents.
        /// </remarks>
        NotSupported = 3,

        /// <summary>
        /// Missing parameters.
        /// </summary>
        /// <remarks>
        /// This will be set when required parameters for canceling payment intent are missing.<br></br>
        /// Usually this will be companion id or transaction id not provided in payment intent.
        /// </remarks>
        MissingParameters = 4
    }
}
