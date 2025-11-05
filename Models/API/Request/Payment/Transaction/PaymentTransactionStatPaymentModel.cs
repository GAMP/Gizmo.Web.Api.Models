namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment transactions payment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTransactionStatPaymentModel : IWebApiModel
    {
        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Total payments in specified payment method.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Total { get; init; }
    }
}
