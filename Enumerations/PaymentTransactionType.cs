using System.ComponentModel.DataAnnotations;

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
        [Name("Invoice Payment", "PAYMENT_TRANSACTION_TYPE_INVOICE_PAYMENT")]
        InvoicePayment = 0,

        /// <summary>
        /// Payment on deposit.
        /// </summary>
        [Name("Deposit Payment", "PAYMENT_TRANSACTION_TYPE_DEPOSIT_PAYMENT")]
        DepositPayment = 1,

        /// <summary>
        /// Payment on pay in.
        /// </summary>
        [Name("Pay In", "PAYMENT_TRANSACTION_TYPE_PAY_IN")]
        PayIn = 2,

        /// <summary>
        /// Invoice payment refund.
        /// </summary>
        [Name("Invoice Payment Refund", "PAYMENT_TRANSACTION_TYPE_INVOICE_PAYMENT_REFUND")]
        InvoicePaymentRefund = 3,

        /// <summary>
        /// Deposit payment refund.
        /// </summary>
        [Name("Deposit Payment Refund", "PAYMENT_TRANSACTION_TYPE_DEPOSIT_PAYMENT_REFUND")]
        DepositPaymentRefund = 4,

        /// <summary>
        /// Pay out.
        /// </summary>
        [Name("Pay Out", "PAYMENT_TRANSACTION_TYPE_PAY_OUT")]
        PayOut = 5,

        /// <summary>
        /// Manual withdraw.
        /// </summary>
        Withdraw = 6,
    }
}
