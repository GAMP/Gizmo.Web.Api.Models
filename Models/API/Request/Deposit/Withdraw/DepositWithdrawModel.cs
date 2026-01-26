namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit withdrawal model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DepositWithdrawModel : IWebApiModel
    {
        /// <summary>
        /// Withdraw amount.
        /// </summary>
        [MessagePack.Key(0)]
        public required decimal Amount { get; init; }

        /// <summary>
        /// Refund payment method id.
        /// </summary>
        [MessagePack.Key(1)]
        public required int RefundPaymentMethodId { get; init; }
    }
}
