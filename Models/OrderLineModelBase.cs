using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line.
    /// </summary>
    [Serializable]
    [DataContract]
    public class OrderLineModelBase
    {
        /// <summary>
        /// The type of the order line.
        /// </summary>
        [DataMember]
        public LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        [DataMember]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the order line.
        /// </summary>
        [DataMember]
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [DataMember]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price for one unit in this order line.
        /// </summary>
        [DataMember]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The tax rate of the order line.
        /// </summary>
        [DataMember]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        [DataMember]
        public decimal PreTaxTotal { get; set; }

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
        /// The cost in points for one unit in this order line.
        /// </summary>
        [DataMember]
        public int UnitPointsPrice { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [DataMember]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The amount of points the user earns from one unit in this order line.
        /// </summary>
        [DataMember]
        public int? UnitPointsAward { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this invoice line.
        /// </summary>
        [DataMember]
        public int? PointsAwardTotal { get; set; }

        /// <summary>
        /// The cost of one unit in this order line.
        /// </summary>
        [DataMember]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// The total cost of this order line.
        /// </summary>
        [DataMember]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Whether all the items of the order line have been delivered.
        /// </summary>
        [DataMember]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The quantity of items that have been delivered.
        /// </summary>
        [DataMember]
        public decimal DeliveredQuantity { get; set; }

        /// <summary>
        /// The Id of the bundle line this line belongs to if the line refers to a bundled product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public int? BundleLineId { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineProduct Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineProduct TimeProduct { get; set; }

    }
}