namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order invoice result.
    /// </summary>
    public enum OrderInvoiceResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Order is in state that does not allow invoicing.
        /// </summary>
        InvalidState = 1,

        /// <summary>
        /// Invalid payments.
        /// </summary>
        InvalidPayments = 2,
    }
}
