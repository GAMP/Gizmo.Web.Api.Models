namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order create result.
    /// </summary>
    /// <remarks>
    /// This is result is used for single order creation.
    /// </remarks>
    public enum OrderCreateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Generic error.
        /// </summary>
        /// <remarks>
        /// This will indicate an error in processing of the order or its parameters.
        /// </remarks>
        Error = 1,

        /// <summary>
        /// Invalid lines.
        /// </summary>
        /// <remarks>
        /// This will indicate an error with some of the order lines.
        /// </remarks>
        InvalidLines = 2,

        /// <summary>
        /// Invalid user id.
        /// </summary>
        /// <remarks>
        /// This will happen if the user id specified in the order does not exist in the database.
        /// </remarks>
        InvalidUserId = 3,

        /// <summary>
        /// No guest group.
        /// </summary>
        /// <remarks>
        /// This will happen if no usable guest group exists in the system and guest order is being processed.
        /// </remarks>
        NoGuestGroup = 4,

        /// <summary>
        /// Invalid source host id.
        /// </summary>
        /// <remarks>
        /// This will indicate that the host id specified for the order does not exist in the database.
        /// </remarks>
        InvalidSourceHostId = 5,

        /// <summary>
        /// Payment exceeds the amount of order.
        /// </summary>
        /// <remarks>
        /// This will indicate an attempt to make an payment which amount exceeds the order totals.
        /// </remarks>
        PaymentExceedsOrderAmount = 6,

        /// <summary>
        /// Partial payment not allowed.
        /// </summary>
        /// <remarks>
        /// This will indicate that its not to partially or pay later. This will be either due to user permission or order type, for example multiple orders cannot be paid partially.
        /// </remarks>
        PartialOrNonPaymentNotAllowed = 7,

        /// <summary>
        /// Empty order.
        /// </summary>
        /// <remarks>
        /// Indicates that order does not have any order lines.
        /// </remarks>
        EmptyOrder = 8,

        /// <summary>
        /// Multiple payment methods not allowed.
        /// </summary>
        MultiplePaymentsNotAllowed = 9,

        /// <summary>
        /// Cannot process order.
        /// </summary>
        /// <remarks>
        /// Indicates cases where payment or stock transactions cannot be processed.
        /// </remarks>
        ErrorProcessing = 10,

        /// <summary>
        /// Invalid payments.
        /// </summary>
        /// <remarks>
        /// Indicates that one or more payments failed due to validation.
        /// </remarks>
        InvalidPayments = 11,

        /// <summary>
        /// Invalid payments parameters.
        /// </summary>
        /// <remarks>Indicates that we have specified both payments and preferred payment parameters.</remarks>
        InvalidPaymentsParameters = 12,
    }
}
