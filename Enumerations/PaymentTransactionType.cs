namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transaction types.
    /// </summary>
    public enum PaymentTransactionType
    {
        /// <summary>
        /// Payment on invoice.
        /// </summary>
        InvoicePayment = 0,

        /// <summary>
        /// Payment on deposit.
        /// </summary>
        DepositPayment = 1,

        /// <summary>
        /// Payment on pay in.
        /// </summary>
        PayIn = 2,

        /// <summary>
        /// Invoice payment refund.
        /// </summary>
        InvoicePaymentRefund = 3,

        /// <summary>
        /// Deposit payment refund.
        /// </summary>
        DepositPaymentRefund = 4,

        /// <summary>
        /// Pay out.
        /// </summary>
        PayOut = 5,

        /// <summary>
        /// Manual withdraw.
        /// </summary>
        Withdraw = 6,
    }
}
