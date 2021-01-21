using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculated order.
    /// </summary>
    [Serializable]
    [DataContract]
    public class CalculatedOrder
    {
        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [DataMember]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [DataMember]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [DataMember]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [DataMember]
        public virtual IEnumerable<OrderLine> OrderLines { get; set; }

    }
}