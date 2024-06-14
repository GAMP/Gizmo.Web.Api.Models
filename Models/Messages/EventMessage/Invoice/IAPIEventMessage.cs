using MessagePack;

namespace Gizmo.Web.Api.Messaging
{    
    [Union(1900, typeof(InvoicedCreatedEventMessage))]
    [Union(1901, typeof(InvoicePaymentEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
