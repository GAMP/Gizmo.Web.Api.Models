﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.Order.Line;

using MessagePack;

using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Models.API.Request.Order.Calculate
{
    /// <summary>
    /// Calculated order.
    /// </summary>
    [MessagePackObject]
    public sealed class CalculatedOrder : ICalculatedOrderApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The subtotal of the order line.
        /// </summary>
        [Key(0)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [Key(1)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [Key(2)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [Key(3)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(4)]
        public IEnumerable<OrderLine> OrderLines { get; set; }

        #endregion
    }
}