namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Refund status.
    /// </summary>
    public enum RefundStatus
    {
        /// <summary>
        /// None.
        /// </summary>
        [Localized("REFUND_STATUS_NONE")]
        None,
        /// <summary>
        /// Partial.
        /// </summary>
        [Localized("REFUND_STATUS_PARTIAL")]
        Partial,
        /// <summary>
        /// Full.
        /// </summary>
        [Localized("REFUND_STATUS_FULL")]
        Full,
    }
}
