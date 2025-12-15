namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization task types.
    /// </summary>
    public enum FiscalizationTaskType
    {
        /// <summary>
        /// Invoice sale.
        /// </summary>
        InvoiceSale = 0,

        /// <summary>
        /// Invoice return.
        /// </summary>
        InvoiceReturn = 1,

        /// <summary>
        /// Deposit payment.
        /// </summary>
        DepositPayment = 2,

        /// <summary>
        /// Deposit refund.
        /// </summary>
        DepositRefund = 3,

        /// <summary>
        /// Register transaction in.
        /// </summary>
        RegisterTransactionIn = 4,

        /// <summary>
        /// Register transaction out.
        /// </summary>
        RegisterTransactionOut = 5,
    }
}
