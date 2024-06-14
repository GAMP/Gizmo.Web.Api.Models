namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Invoice event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Invoice", "INVOICE_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Invoice related events", "INVOICE_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(19)]
    [MessagePack.MessagePackObject()]
    public abstract class InvoiceEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public InvoiceEventMessageBase() : base()
        { }

        /// <summary>
        /// Invoice id.
        /// </summary>
        [MessagePack.Key(1)]
        public int InvoiceId { get; init; }

        /// <summary>
        /// Invoice order id.
        /// </summary>
        [MessagePack.Key(2)]
        public int OrderId { get; init; }
    }
}
