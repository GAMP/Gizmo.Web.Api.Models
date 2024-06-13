namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Active order status.
    /// </summary>
    public enum ActiveOrderStatus
    {
        /// <summary>
        /// Order is on hold.
        /// </summary>
        OnHold = 0,
        /// <summary>
        /// Order is processing.
        /// </summary>
        Processing = 1,
        /// <summary>
        /// Order is invoiced.
        /// </summary>
        Invoiced = 2,
    }
}
