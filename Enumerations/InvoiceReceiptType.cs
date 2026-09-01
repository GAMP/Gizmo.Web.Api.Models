namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// POS invoice receipt type.
    /// </summary>
    public enum InvoiceReceiptType
    {
        /// <summary>
        /// Sale receipt.
        /// </summary>
        Income = 0,

        /// <summary>
        /// Return receipt.
        /// </summary>
        Outcome = 1
    }
}
