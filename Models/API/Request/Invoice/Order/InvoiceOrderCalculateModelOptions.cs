#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice user order options.
    /// </summary>
    [MessagePackObject]
    public sealed class InvoiceOrderCalculateModelOptions : IInvoiceOrderOptionsApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The order object to invoice.
        /// </summary>
        [Key(0)]
        public OrderCalculateModelOptions? Order { get; set; }

        /// <summary>
        /// The list of payments for the invoice.
        /// </summary>
        [Key(1)]
        public IEnumerable<InvoicePaymentModelShort>? Payments { get; set; }

        #endregion
    }
}