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

        /// <summary>
        /// Whether the invoice already existed before this checkout (a pre-existing billing obligation) rather than
        /// being created fresh in it. A pre-existing invoice must never be voided on a payment or receipt-print
        /// failure; only transient (newly created) invoices are voidable.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsExisting { get; init; }
    }
}
