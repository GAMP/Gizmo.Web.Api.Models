namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation payment type.
    /// </summary>
    public enum ReservationPaymentType
    {
        /// <summary>
        /// Invoice payment.
        /// </summary>
        InvoicePayment = 0,

        /// <summary>
        /// Intent payment.
        /// </summary>
        IntentPayment = 1,
    }
}
