namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Payment transaction direction.
    /// </summary>
    public enum PaymentTransactionDirection
    {
        /// <summary>
        /// In payment direction.
        /// </summary>
        /// <remarks>
        /// This will indicate payments that we have recieved.
        /// </remarks>
        In = 0,

        /// <summary>
        /// Out payment direction.
        /// </summary>
        /// <remarks>
        /// This will indicate payments that we have paid out, for example refunds or register transactions.
        /// </remarks>
        Out = 1,
    }
}
