namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Specifies the void status of the invoices displayed.
    /// </summary>
    public enum InvoicesLogVoidedStatusTypes : short
    {
        /// <summary>
        /// Only non voided invoices are displayed.
        /// </summary>
        No = 1,

        /// <summary>
        /// Only voided invoices are displayed.
        /// </summary>
        Yes = 2
    }
}
