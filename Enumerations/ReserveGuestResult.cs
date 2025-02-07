namespace Gizmo.Web.Api.Models
{
    public enum ReserveGuestResult
    {
        Success = 0,
        InvalidSlot = 1,
        NoGuestGroup = 2,
        GuestUseNotAllowed = 3,
        HostOutOfOrder = 4,
        MaxReservationsReached = 5,
        SlotInUse = 6,
    }
}
