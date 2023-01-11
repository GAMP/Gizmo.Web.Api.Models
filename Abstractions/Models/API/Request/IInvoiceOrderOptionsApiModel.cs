using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    public interface IInvoiceOrderOptionsApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        IEnumerable<InvoicePaymentModelShort> Payments { get; set; }
    }
}