using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount reward type enumeration.
    /// </summary>
    public enum DiscountRewardType
    {
        /// <summary>
        /// Discount.
        /// </summary>
        [Name("Discount", "DISCOUNT_REWARD_TYPE_DISCOUNT")]
        Discount = 0,

        /// <summary>
        /// Bonus.
        /// </summary>
        [Name("Bonus", "DISCOUNT_REWARD_TYPE_BONUS")]
        Bonus = 1,
    }
}
