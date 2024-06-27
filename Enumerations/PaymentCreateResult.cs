﻿namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Payment creation result.
    /// </summary>
    public enum PaymentCreateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Insufficient funds.
        /// </summary>
        InsufficientFunds = 1,

        /// <summary>
        /// Invalid payment method id.
        /// </summary>
        /// <remarks>
        /// This will indicate the the payment method id specified does not exist in the database.
        /// </remarks>
        InvalidPaymentMethodId = 2,

        /// <summary>
        /// Invalid payment amount.
        /// </summary>
        /// <remarks>
        /// This will indicate that zero or negative amount specified for payment.
        /// </remarks>
        InvalidPaymentAmount = 3,

        /// <summary>
        /// Invalid received amount.
        /// </summary>
        /// <remarks>
        /// This will indicate that received amount is less or equal to zero or received amount is less than payment amount.
        /// </remarks>
        InvalidReceivedAmount = 4,

        /// <summary>
        /// Payment method not allowed.
        /// </summary>
        /// <remarks>
        /// This will indicate an attempt to use an payment method that is not allowed, for example specifying points as payment method.
        /// </remarks>
        PaymentMethodNotAllowed = 5,

        /// <summary>
        /// Non unique payment method.
        /// </summary>
        /// <remarks>
        /// This will indicate that same payment method where specified multiple times.
        /// </remarks>
        NonUniquePaymentMethod = 6,
    }
}
