namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order delivery status.
    /// </summary>
    public enum OrderDeliveryStatus
    {
        /// <summary>
        /// Undelivered.
        /// </summary>
        Undelivered = 0,

        /// <summary>
        /// Partially delivered.
        /// </summary>
        Partial = 1,

        /// <summary>
        /// Fully delivered.
        /// </summary>
        Full = 2
    }
}
