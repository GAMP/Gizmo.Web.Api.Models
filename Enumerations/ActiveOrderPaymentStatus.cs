namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Active order payment status.
    /// </summary>
    public enum ActiveOrderPaymentStatus
    {
        /// <summary>
        /// Order is unpaid.
        /// </summary>
        Unpaid = 0,

        /// <summary>
        /// Order is partially paid.
        /// </summary>
        PartiallyPaid =1,

        /// <summary>
        /// Order is fully paid.
        /// </summary>
        Paid = 2,
    }
}
