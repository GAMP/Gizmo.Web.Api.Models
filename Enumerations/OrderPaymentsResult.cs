namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order payments result.
    /// </summary>
    public enum OrderPaymentsResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Payments exceeds the amount of order.
        /// </summary>
        /// <remarks>
        /// This will indicate an attempt to make an payment which amount exceeds the order totals.
        /// </remarks>
        PaymentsExceedsOrderAmount = 1,     

        /// <summary>
        /// Partial payment not allowed.
        /// </summary>
        /// <remarks>
        /// This will indicate that its not to partially or pay later. This will be either due to user permission or order type, for example multiple orders cannot be paid partially.
        /// </remarks>
        PartialOrNonPaymentNotAllowed = 2,

        /// <summary>
        /// Non unique payments.
        /// </summary>
        /// <remarks>
        /// This will indicate that same payment method was specified multiple times.
        /// </remarks>
        NonUniquePayments = 3,

        /// <summary>
        /// Payments error.
        /// </summary>
        PaymentsError = 4,

        /// <summary>
        /// The order is already fully paid.
        /// </summary>
        AlreadyPaid = 5,
        /// <summary>
        /// Order is voided.
        /// </summary>
        Voided = 6,
    }
}
