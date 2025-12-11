namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit payment creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DepositPaymentCreateModel : IWebApiModel
    {
        /// <summary>
        /// Deposit amount.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(1)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Disable receipt printing.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DisableReceiptPrinting { get; init; }
    }
}
