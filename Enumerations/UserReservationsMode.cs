namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mode of the user reservations list.
    /// </summary>
    public enum UserReservationsMode
    {
        /// <summary>
        /// Current and upcoming reservations: waiting or active and not ended yet, start ascending.
        /// </summary>
        Current = 0,

        /// <summary>
        /// Every other reservation: completed, canceled, expired and ended ones, start descending.
        /// </summary>
        Completed = 1
    }
}
