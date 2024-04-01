namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order payment creation error result.
    /// </summary>
    public enum OrderPaymentCreateErrorResult
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
