namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent cancel result codes.
    /// </summary>
    public enum PaymentIntentCancelResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Invalid identifier.
        /// </summary>
        /// <remarks>
        /// This will indicate that no payment intent with provided identifier was found.
        /// </remarks>
        InvalidIdentifier = 1,

        /// <summary>
        /// Invalid intent state.
        /// </summary>
        /// <remarks>
        /// This will indicate that intent is not in pending state and cannot be canceled.
        /// </remarks>
        InvalidIntentState = 2,

        /// <summary>
        /// Internal error.
        /// </summary>
        InternalError = 3,
    }
}
