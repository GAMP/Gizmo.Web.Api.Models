namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift payment expect amount model.
    /// </summary>
    public interface IShiftExpectedTransactionModel : IWebApiModel
    {
        /// <summary>
        /// Transaction payment method id.
        /// </summary>
        int PaymentMethodId { get; }

        /// <summary>
        /// Total amount.
        /// </summary>
        decimal Amount { get; }

        /// <summary>
        /// Transactions count.
        /// </summary>
        /// <remarks>
        /// This will include any payments or refund transactions.
        /// </remarks>
        public int Count { get; }
    }
}
