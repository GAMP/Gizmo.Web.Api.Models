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
        public FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }

        /// <summary>
        /// Id of the created refund (deposit-payment refund) record, when a refund was made.
        /// </summary>
        /// <remarks>
        /// Null for a no-refund void (no refund record is created). When set, this is the id to wait on for the
        /// return (void) receipt via the deposit-payment refund-receipt wait.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? RefundId { get; init; }
    }
}
