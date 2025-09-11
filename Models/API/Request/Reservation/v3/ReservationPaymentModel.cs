namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation payment model.
    /// </summary>
    [MessagePack.Union((int)ReservationPaymentType.InvoicePayment, typeof(ReservationInvoicePaymentModel))]
    [MessagePack.Union((int)ReservationPaymentType.IntentPayment, typeof(ReservationPaymentPaymentIntentModel))]
    [MessagePack.MessagePackObject()]
    public abstract class ReservationPaymentModel : IWebApiModel
    {
    }    
}
