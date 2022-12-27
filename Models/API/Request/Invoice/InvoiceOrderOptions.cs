using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.Invoice.Payment;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Models.API.Request.Invoice
{
    /// <summary>
    /// Invoice order options.
    /// </summary>
    [MessagePackObject]
    public sealed class InvoiceOrderOptions : IInvoiceOrderOptionsApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        [Key(0)]
        public IEnumerable<InvoicePaymentModel> Payments { get; set; }

        #endregion
    }
}