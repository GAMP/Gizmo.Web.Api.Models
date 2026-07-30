namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Supported non-fiscal receipt document kinds.
    /// </summary>
    public enum NonFiscalReceiptKind
    {
        /// <summary>
        /// Invoice receipt.
        /// </summary>
        Invoice = 0,

        /// <summary>
        /// Deposit receipt.
        /// </summary>
        Deposit = 1,
    }
}
