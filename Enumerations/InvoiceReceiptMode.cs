namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// POS invoice receipt query mode.
    /// </summary>
    public enum InvoiceReceiptMode
    {
        /// <summary>
        /// Fiscalized sale receipts.
        /// </summary>
        Income = 0,

        /// <summary>
        /// Fiscalized return receipts.
        /// </summary>
        Outcome = 1,

        /// <summary>
        /// Sale receipts that failed to print.
        /// </summary>
        IncomeUnprinted = 2,

        /// <summary>
        /// Return receipts that failed to print.
        /// </summary>
        OutcomeUnprinted = 3
    }
}
