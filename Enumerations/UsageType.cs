namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Defines time usage type.
    /// </summary>
    public enum UsageType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Billing profile rate.
        /// </summary>
        Rate = 1,

        /// <summary>
        /// Fixed time.
        /// </summary>
        TimeFixed = 2,

        /// <summary>
        /// Time offer.
        /// </summary>
        TimeOffer = 3,
    }
}
