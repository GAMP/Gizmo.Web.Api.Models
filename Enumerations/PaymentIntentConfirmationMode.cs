namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent confirmation mode.
    /// </summary>
    public enum PaymentIntentConfirmationMode
    {
        /// <summary>
        /// Synchronous confirmation mode.
        /// </summary>
        /// <remarks>
        /// It is expected that the payment intent will be confirmed immediately upon creation.
        /// </remarks>
        Synchronous = 0,

        /// <summary>
        /// Asynchronous confirmation mode.
        /// </summary>
        /// <remarks>
        /// It is expected that the payment intent will be confirmed at a later time after creation.
        /// </remarks>
        Asynchronous = 1
    }
}
