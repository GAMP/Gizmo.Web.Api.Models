namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment model.
    /// </summary>
    [MessagePack.Union((int)ReservationPaymentType.InvoicePayment, typeof(InvoicePaymentPaymentModel))]
    [MessagePack.Union((int)ReservationPaymentType.IntentPayment, typeof(PaymentPaymentIntentModel))]
    [MessagePack.MessagePackObject()]
    public abstract class PaymentModel : IWebApiModel
    {
    }    
}
