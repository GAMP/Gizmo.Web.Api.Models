namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of an online payment of a reservation.
    /// </summary>
    public enum UserReservationPayResult
    {
        /// <summary>
        /// The payment is created.
        /// </summary>
        Success = 0,

        /// <summary>
        /// The reservation cannot be paid online: it is not owned by the user, is not waiting, is not unpaid or has no single unpaid invoice.
        /// </summary>
        NotPayable = 1,

        /// <summary>
        /// A payment of the reservation is already pending.
        /// </summary>
        PaymentInProgress = 2
    }
}
