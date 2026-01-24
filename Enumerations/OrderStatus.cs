namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order status.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// On hold.
        /// </summary>
        OnHold = 0,

        /// <summary>
        /// Completed.
        /// </summary>
        Completed = 1,

        /// <summary>
        /// Canceled.
        /// </summary>
        Canceled = 2,

        /// <summary>
        /// Accepted.
        /// </summary>
        Accepted = 3,

        /// <summary>
        /// Processing.
        /// </summary>
        Processing = 4,
    }
}
