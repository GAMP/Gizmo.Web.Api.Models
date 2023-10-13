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
        public int Count { get; }
    }
}
