namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of a reservation offer request.
    /// </summary>
    public enum UserReservationOfferResult
    {
        /// <summary>
        /// The offer is created.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Some of the hosts are not available for the period.
        /// </summary>
        HostsUnavailable = 1,

        /// <summary>
        /// Some of the hosts belong to a host group without a usable offer.
        /// </summary>
        NoPrice = 2
    }
}
