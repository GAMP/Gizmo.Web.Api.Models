namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order void status.
    /// </summary>
    public enum OrderVoidStatus
    {
        /// <summary>
        /// No void status.
        /// </summary>
        None = 0,

        /// <summary>
        /// Partially voided.
        /// </summary>
        /// <remarks>
        /// Some order invoices are void.
        /// </remarks>
        Partial = 1,

        /// <summary>
        /// Fully voided.
        /// </summary>
        /// <remarks>
        /// All order invoices are void.
        /// </remarks>
        Full = 2
    }
}
