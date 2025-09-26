using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion type.
    /// </summary>
    public enum PromotionCodeType
    {
        /// <summary>
        /// Public promotion.
        /// </summary>
        [Name("Public", "PROMOTION_CODE_TYPE_PUBLIC_NAME")]
        Public = 0,

        /// <summary>
        /// Restricted promotion.
        /// </summary>
        [Name("Restricted", "PROMOTION_CODE_TYPE_RESTRICTED_NAME")]
        Restricted = 1,
    }
}
