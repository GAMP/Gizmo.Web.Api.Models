namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Specifies the type of the product transaction.
    /// </summary>
    public enum ProductTransactionTypes : short
    {
        /// <summary>
        /// Transaction from stock change.
        /// </summary>
        Set = 1,

        /// <summary>
        /// Transaction from sale.
        /// </summary>
        Sell = 2,

        /// <summary>
        /// Transaction from void.
        /// </summary>
        Return = 3
    }
}
