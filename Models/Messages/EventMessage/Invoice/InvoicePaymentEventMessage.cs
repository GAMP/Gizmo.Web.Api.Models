using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Invoice payment event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Payment", "INVOICE_PAYMENT_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates creation of an invoice payment", "INVOICE_PAYMENT_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class InvoicePaymentEventMessage : InvoiceEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoicePaymentEventMessage() : base()
        { }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [Key(3)]
        public int? PaymentMethodId
        {
            get; init;
        }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [Key(4)]
        public decimal Amount
        {
            get; init;
        }

        /// <summary>
        /// Outstanding amount on invoice.
        /// </summary>
        [Key(5)]
        public decimal Outstanding
        {
            get; init;
        }
    }
}
