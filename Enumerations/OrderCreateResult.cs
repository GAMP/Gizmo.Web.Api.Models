namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order create result.
    /// </summary>
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
        /// Invalid payment method id.
        /// </summary>
        /// <remarks>
        /// This will indicate the the payment method id specified does not exist in the database.
        /// </remarks>
        InvalidPaymentMethodId = 7,

        /// <summary>
        /// Invalid payment amount.
        /// </summary>
        /// <remarks>
        /// This will indicate that zero or negative amount specified for payment.
        /// </remarks>
        InvalidPaymentAmount = 8,

        /// <summary>
        /// Partial payment not allowed.
        /// </summary>
        /// <remarks>
        /// This will indicate that its not to partially or pay later. This will be either due to user permission or order type, for example multiple orders cannot be paid partially.
        /// </remarks>
        PartialOrNonPaymentNotAllowed = 9,

        /// <summary>
        /// Empty order.
        /// </summary>
        /// <remarks>
        /// Indicates that order does not have any order lines.
        /// </remarks>
        EmptyOrder = 10,

        /// <summary>
        /// Specified payment method is not allowed for the current order.
        /// </summary>
        NotAllowedPaymentMethod = 11,

        /// <summary>
        /// Multiple payment methods not allowed.
        /// </summary>
        MultiplePaymentsNotAllowed = 12,

        /// <summary>
        /// Cannot process order.
        /// </summary>
        /// <remarks>
        /// Indicates cases where payment or stock transactions cannot be processed.
        /// </remarks>
        ErrorProcessing = 13,
    }
}
