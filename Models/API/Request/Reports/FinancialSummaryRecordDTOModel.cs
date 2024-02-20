namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Financial Summary Record.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class FinancialSummaryRecordDTOModel
    {
        /// <summary>
        /// Payment method Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Payment method name.
        /// </summary>
        [MessagePack.Key(1)]
        public string PaymentMethodName { get; set; }

        /// <summary>
        /// Number of items within the record.
        /// </summary>
        [MessagePack.Key(2)]
        public int Quantity { get; set; }

        /// <summary>
        /// Value of items within the record.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Value { get; set; }

        /// <summary>
        /// Record refers to a voided invoice.
        /// </summary>
        [MessagePack.Key(4)]
        public bool InvoiceIsVoided { get; set; }
    }
}
