using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.Product;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Invoice
{
    /// <summary>
    /// Invoice line.
    /// </summary>
    [MessagePackObject]
    public sealed class InvoiceLine : IInvoiceLineApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The type of the invoice line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public LineType LineType { get; set; }

        /// <summary>
        /// The pay type of the invoice line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The name of the item in the invoice line.
        /// </summary>
        [MessagePack.Key(3)]
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity of items in the invoice line.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price for one unit in this invoice line.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The tax rate of the invoice line.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal PreTaxTotal { get; set; }

        /// <summary>
        /// The total tax of the invoice line.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the invoice line.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Total { get; set; }

        /// <summary>
        /// The cost in points for one unit in this order line.
        /// </summary>
        [MessagePack.Key(10)]
        public int UnitPointsPrice { get; set; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [MessagePack.Key(11)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The amount of points the user earns from one unit in this order line.
        /// </summary>
        [MessagePack.Key(12)]
        public int? UnitPointsAward { get; set; }

        /// <summary>
        /// The total amount of points the user earns from this invoice line.
        /// </summary>
        [MessagePack.Key(13)]
        public int? PointsAwardTotal { get; set; }

        /// <summary>
        /// The cost of one unit in this invoice line.
        /// </summary>
        [MessagePack.Key(14)]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// The total cost of this invoice line.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// The product object attached to this invoice line if the invoice line refers to a product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(16)]
        public LineProduct Product { get; set; }

        /// <summary>
        /// The time product object attached to this invoice line if the invoice line refers to a time product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(17)]
        public LineProduct TimeProduct { get; set; }

        /// <summary>
        /// The Id of the bundle line this line belongs to if the line refers to a bundled product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(18)]
        public int? BundleLineId { get; set; }

        #endregion
    }
}