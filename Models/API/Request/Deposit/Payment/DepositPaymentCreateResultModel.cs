namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit payment creation result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DepositPaymentCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Deposit payment id.
        /// </summary>
        [MessagePack.Key(0)]
        public int DepositPaymentId { get; init; }

        /// <summary>
        /// Payment id.
        /// </summary>
        [MessagePack.Key(1)]
        public int PaymentId { get; init; }

        /// <summary>
        /// Receipt print status.
        /// </summary>
        [MessagePack.Key(2)]
        public Gizmo.FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }
    }
}
