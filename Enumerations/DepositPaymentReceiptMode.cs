namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// POS deposit payment receipt query mode.
    /// </summary>
    public enum DepositPaymentReceiptMode
    {
        /// <summary>
        /// Fiscalized deposit income receipts.
        /// </summary>
        Income = 0,

        /// <summary>
        /// Deposit income receipts that failed to print.
        /// </summary>
        IncomeUnprinted = 1
    }
}
