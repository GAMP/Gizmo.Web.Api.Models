﻿namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Invoice payment.
    /// </summary>
    public interface IInvoicePaymentApiModel
    {
        /// <summary>
        /// The amount of the invoice payment.
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// The amount received for the invoice payment.
        /// </summary>
        decimal AmountReceived { get; set; }

        /// <summary>
        /// The Id of the payment method this invoice payment is associated with.
        /// </summary>
        int PaymentMethodId { get; set; }
    }
}