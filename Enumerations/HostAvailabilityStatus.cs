namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host reservation availability status.
    /// </summary>
    public enum HostReservationAvailabilityStatus
    {
        /// <summary>
        /// Host is available for reservation.
        /// </summary>
        Available = 0,

        /// <summary>
        /// Host is reserved in the specified period.
        /// </summary>
        Reserved = 1,
        
        /// <summary>
        /// Host is in use for specified period, meaning that it is currently being used by a user.
        /// </summary>
        InUse = 2,
    }
}
