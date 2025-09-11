using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount value type.
    /// </summary>
    public enum DiscountCalculationType
    {
        /// <summary>
        /// Percentage discount.
        /// </summary>
        [Name("Percentage", "DISCOUNT_CALCULATION_TYPE_PERCENTAGE")]
        Percentage = 0,

        /// <summary>
        /// Fixed discount.
        /// </summary>
        [Name("Fixed", "DISCOUNT_CALCULATION_TYPE_FIXED")]
        Fixed = 1,
    }
}
