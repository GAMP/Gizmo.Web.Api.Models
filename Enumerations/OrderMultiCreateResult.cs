namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Multi order creation result.
    /// </summary>
    /// <remarks>
    /// This result is used for multiple order creation.
    /// </remarks>
    public enum OrderMultiCreateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Orders failed.
        /// </summary>
        /// <remarks>
        /// Indicates one or more orders failed either due to validation or error.
        /// </remarks>
        OrdersFailed = 1,

        /// <summary>
        /// Empty order.
        /// </summary>
        /// <remarks>
        /// Indicates that no orders been provided in parameters.
        /// </remarks>
        EmptyOrder = 1,

        /// <summary>
        /// Multiple payments not allowed.
        /// </summary>
        /// <remarks>
        /// Indicates an attempt to pay for multiple orders with multiple payment methods.
        /// </remarks>
        MultiplePaymentsNotAllowed = 2,

        /// <summary>
        /// Partial payment not allowed.
        /// </summary>
        /// <remarks>
        /// Indicates an attempt to pay for multiple orders with pay later or partially.
        /// </remarks>
        PartialOrNonPaymentNotAllowed = 3,

        /// <summary>
        /// Invalid payments parameters.
        /// </summary>
        /// <remarks>Indicates that we have specified both payments and preferred payment parameters.</remarks>
        InvalidPaymentsParameters = 4,
    }
}
