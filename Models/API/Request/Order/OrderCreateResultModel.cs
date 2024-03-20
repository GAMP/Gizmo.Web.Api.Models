using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Enumerations;
using Gizmo.Web.Api.Models.Models;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderCreateResultModel :IWebApiModel
    {
        /// <summary>
        /// Unique client side request identification of order line.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// Creation result.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderCreateResult Result { get; init; }

        /// <summary>
        /// Gets the created order id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OrderId
        {
            get; init;
        }    

        /// <summary>
        /// Gets order status.
        /// </summary>
        /// <remarks>
        /// This will only have value if order was created.
        /// </remarks>
        [MessagePack.Key(3)]
        public Gizmo.OrderStatus OrderStatus
        {
            get; init;
        }

        /// <summary>
        /// Gets created invoice id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? InoviceId
        {
            get; init;
        }

        /// <summary>
        /// Gets invoice status.
        /// </summary>
        /// <remarks>
        /// This will only have value if invoice was created.
        /// </remarks>
        [MessagePack.Key(5)]
        public Gizmo.InvoiceStatus? InvoiceStatus
        {
            get; init;
        }

        /// <summary>
        /// Gets invalid lines.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<OrderLineValidatonResultModel> InvalidLines { get; init; } = [];

        /// <summary>
        /// Result readable.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public string ResultReadable
        {
            get { return Result.ToString(); }
        }
    }
}
