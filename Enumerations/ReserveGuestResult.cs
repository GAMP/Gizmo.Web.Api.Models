namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reserve guest result.
    /// </summary>
    public enum ReserveGuestResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Invalid slot.
        /// </summary>
        InvalidSlot = 1,

        /// <summary>
        /// No guest group to use.
        /// </summary>
        NoGuestGroup = 2,

        /// <summary>
        /// Guest use not allowed.
        /// </summary>
        GuestUseNotAllowed = 3,

        /// <summary>
        /// Host is out of order.
        /// </summary>
        HostOutOfOrder = 4,

        /// <summary>
        /// Max reservations reached.
        /// </summary>
        MaxReservationsReached = 5,

        /// <summary>
        /// Slot is in use.
        /// </summary>
        SlotInUse = 6,
    }
}
