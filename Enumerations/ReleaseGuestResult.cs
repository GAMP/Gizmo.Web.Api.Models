namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Release guest result.
    /// </summary>
    public enum ReleaseGuestResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Specified guest user is not reserved.
        /// </summary>
        NotReserved = 1,

        /// <summary>
        /// Specified user still has outstanding invoices.
        /// </summary>
        Outstanding = 2,
    }
}
