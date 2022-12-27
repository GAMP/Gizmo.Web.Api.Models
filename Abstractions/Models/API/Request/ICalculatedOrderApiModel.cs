using Gizmo.Web.Api.Models.Models.API.Request.Order.Line;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Calculated order.
    /// </summary>
    public interface ICalculatedOrderApiModel
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        IEnumerable<OrderLine> OrderLines { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        int PointsTotal { get; set; }

        /// <summary>
        /// The subtotal of the order line.
        /// </summary>
        decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        decimal Total { get; set; }
    }
}