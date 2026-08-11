using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment method associated with an invoice receipt.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoiceReceiptPaymentMethodModel : IWebApiModel
    {
        /// <summary>
        /// Payment method identifier.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Payment method name.
        /// </summary>
        [Key(1)]
        public string? Name { get; init; }
    }
}
