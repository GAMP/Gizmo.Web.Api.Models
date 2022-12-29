using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice user order options.
    /// </summary>
    [MessagePackObject]
    public sealed class CalculateInvoiceOrderOptions : IInvoiceOrderOptionsApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The order object to invoice.
        /// </summary>
        [Key(1)]
        public CalculateOrderOptionsModel Order { get; set; }

        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        [Key(2)]
        public IEnumerable<InvoicePaymentModel> Payments { get; set; }

        #endregion
    }
}