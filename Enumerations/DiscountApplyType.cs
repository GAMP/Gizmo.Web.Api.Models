using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount apply type.
    /// </summary>
    public enum DiscountApplyType
    {
        /// <summary>
        /// Discount is applied to an order line.
        /// </summary>
        [Name("Order Line", "DISCOUNT_APPLY_TYPE_ORDER_LINE")]
        OrderLine = 0,

        /// <summary>
        /// Discount is applied to an order.
        /// </summary>
        [Name("Order", "DISCOUNT_APPLY_TYPE_ORDER")]
        Order = 1,
    }
}
