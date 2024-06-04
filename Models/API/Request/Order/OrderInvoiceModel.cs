﻿using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order invoice model.
    /// </summary>
    /// <remarks>
    /// Model used to create invoice for existing order.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class OrderInvoiceModel : IWebApiModel
    {
        /// <summary>
        /// Gets invoice payments.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<PaymentCreateModel> Payments { get; init; } = Enumerable.Empty<PaymentCreateModel>();
    }
}
