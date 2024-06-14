using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Invoice created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Created", "INVOICE_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates creation of an invoice", "INVOICE_CREATED_EVENT_DESCRIPTION")]
    [MessagePackObject()]
    public sealed class InvoicedCreatedEventMessage : InvoiceEventMessageBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoicedCreatedEventMessage() : base()
        { }       
    }
}
