namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line creation model types.
    /// </summary>
    public enum OrderLineCreateType
    {
        /// <summary>
        /// Product.
        /// </summary>
        Product = 0,
        /// <summary>
        /// Fixed time.
        /// </summary>
        FixedTime = 1,
        /// <summary>
        /// Deposit.
        /// </summary>
        Deposit = 2,
    }
}
