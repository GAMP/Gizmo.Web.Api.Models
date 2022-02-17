using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice line.
    /// </summary>
    [Serializable]
    [DataContract]
    public class InvoiceLineModelBase
    {
        /// <summary>
        /// The type of the invoice line.
        /// </summary>
        [DataMember]
        [EnumValue]
        public LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the invoice line.
        /// </summary>
        [DataMember]
        [EnumValue]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the invoice line.
        /// </summary>
        [DataMember]
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity of items in the invoice line.
        /// </summary>
        [DataMember]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price for one unit in this invoice line.
        /// </summary>
        [DataMember]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The tax rate of the invoice line.
        /// </summary>
        [DataMember]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        [DataMember]
        public decimal PreTaxTotal { get; set; }

        /// <summary>
        /// The total tax of the invoice line.
        /// </summary>
        [DataMember]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the invoice line.
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
        /// The cost of one unit in this invoice line.
        /// </summary>
        [DataMember]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// The total cost of this invoice line.
        /// </summary>
        [DataMember]
        public decimal? Cost { get; set; }

        /// <summary>
        /// The product object attached to this invoice line if the invoice line refers to a product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineProduct Product { get; set; }

        /// <summary>
        /// The time product object attached to this invoice line if the invoice line refers to a time product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineProduct TimeProduct { get; set; }

        /// <summary>
        /// The Id of the bundle line this line belongs to if the line refers to a bundled product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public int? BundleLineId { get; set; }
    }
}