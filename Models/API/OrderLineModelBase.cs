﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class OrderLineModelBase
    {
        /// <summary>
        /// The type of the order line.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(0)]
        public LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(1)]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price for one unit in this order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The tax rate of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public decimal PreTaxTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public decimal Total { get; set; }

        /// <summary>
        /// The cost in points for one unit in this order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public int UnitPointsPrice { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(10)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The amount of points the user earns from one unit in this order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(11)]
        public int? UnitPointsAward { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this invoice line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(12)]
        public int? PointsAwardTotal { get; set; }

        /// <summary>
        /// The cost of one unit in this order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(13)]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// The total cost of this order line.
        /// </summary>
        [DataMember]
        [MessagePack.Key(14)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Whether all the items of the order line have been delivered.
        /// </summary>
        [DataMember]
        [MessagePack.Key(15)]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// The quantity of items that have been delivered.
        /// </summary>
        [DataMember]
        [MessagePack.Key(16)]
        public decimal DeliveredQuantity { get; set; }

        /// <summary>
        /// The Id of the bundle line this line belongs to if the line refers to a bundled product, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(17)]
        public int? BundleLineId { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(18)]
        public LineProduct Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(19)]
        public LineProduct TimeProduct { get; set; }

    }
}