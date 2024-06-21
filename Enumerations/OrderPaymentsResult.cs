namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order payments result.
    /// </summary>
    /// <remarks>
    /// This result is used for single order payment.
    /// </remarks>
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
        /// Invalid payments.
        /// </summary>
        /// <remarks>
        /// Indicates that one or more payments failed due to validation.
        /// </remarks>
        InvalidPayments = 3,

        /// <summary>
        /// The order is already fully paid.
        /// </summary>
        AlreadyPaid = 4,

        /// <summary>
        /// Order is voided.
        /// </summary>
        Voided = 5,

        /// <summary>
        /// Cannot process order.
        /// </summary>
        /// <remarks>
        /// Indicates cases where payment or stock transactions cannot be processed.
        /// </remarks>
        ErrorProcessing = 6,
    }
}
