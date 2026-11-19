namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of a reservation booking.
    /// </summary>
    public enum UserReservationBookResult
    {
        /// <summary>
        /// The reservation is created.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Some of the hosts are no longer available.
        /// </summary>
        HostsUnavailable = 1,

        /// <summary>
        /// The user deposit is not enough to pay the amount.
        /// </summary>
        InsufficientDeposit = 2,

        /// <summary>
        /// The offer is not found, expired or does not belong to the user.
        /// </summary>
        OfferExpired = 3,

        /// <summary>
        /// The reservation is created but the online payment could not be started; the reservation stays not paid.
        /// </summary>
        PaymentNotStarted = 4
    }
}
