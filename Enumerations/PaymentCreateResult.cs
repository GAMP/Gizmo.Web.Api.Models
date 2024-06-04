namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Payment creation result.
    /// </summary>
    public enum PaymentCreateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,
        /// <summary>
        /// Insufficient funds.
        /// </summary>
        InsufficientFunds = 1,
    }
}
