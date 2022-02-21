using MessagePack;
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
    [MessagePackObject]
    public class CalculatedOrder
    {
        /// <summary>
        /// The subtotal of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The lines of the order.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public IEnumerable<OrderLine> OrderLines { get; set; }

    }
}