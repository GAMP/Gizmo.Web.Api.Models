namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promo code apply status.
    /// </summary>
    /// <remarks>
    /// Used to indicate current promo code application status.
    /// </remarks>
    public enum PromoCodeApplyStatus
    {
        /// <summary>
        /// No promo code.
        /// </summary>
        /// <remarks>
        /// This will be set if no promo code used.
        /// </remarks>
        None = 0,

        /// <summary>
        /// Applied.
        /// </summary>
        /// <remarks>
        /// This will be set if at least on of order entry used the promotion discount.
        /// </remarks>
        Applied = 1,

        /// <summary>
        /// Not applied.
        /// </summary>
        /// <remarks>
        /// This will be set in case no order entry matching the promotion discount.
        /// </remarks>
        NotApplied = 2,

        /// <summary>
        /// Promo code cant be used.
        /// </summary>
        Unusable = 3,
    }
}
