namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit payment refund result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DepositPaymentRefundResultModel : IWebApiModel
    {
        /// <summary>
        /// Receipt print status.
        /// </summary>
        [MessagePack.Key(0)]
        public Gizmo.Web.Api.Models.FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }
    }
}
