namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Close balance invoice model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CloseBalanceResultInvoiceModel : IWebApiModel
    {
        /// <summary>
        /// Invoice id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoiceId { get; init; }

        /// <summary>
        /// Receipt print status.
        /// </summary>
        [MessagePack.Key(1)]
        public FiscalReceiptPrintStatus ReceiptPrintStatus { get; init; }
    }
}
