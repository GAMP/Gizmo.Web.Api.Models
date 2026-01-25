namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice refund create result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoiceRefundCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Receipt print status.
        /// </summary>
        [MessagePack.Key(0)]
        public Gizmo.Web.Api.Models.FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }
    }
}
