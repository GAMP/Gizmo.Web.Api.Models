using Gizmo.Web.Api.Models.Models.API.Request.Invoice.Payment;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    public interface IInvoiceOrderOptionsApiModel
    {
        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        IEnumerable<InvoicePaymentModel> Payments { get; set; }
    }
}