using System;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product creation order line model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLineCreateProductModel : IOrderLineCreateModel
    {
        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        public OrderLineCreateType Type =>  OrderLineCreateType.Product;

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// The Id of the time product.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// Order line pay type.
        /// </summary>
        /// <remarks>
        /// This parameter indicates how this order line is expected to be paid.
        /// </remarks>
        [MessagePack.Key(2)]
        public Gizmo.OrderLinePayType PayType { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Whether to use the custom price for this order line. 
        /// </summary>
        [MessagePack.Key(4)]
        public bool IsCustomPrice { get; set; }

        /// <summary>
        /// The custom price of the order line.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal? CustomPrice { get; set; }

        /// <summary>
        /// The mark if the product is marked product.
        /// </summary>
        [MessagePack.Key(6)]
        public string? Mark { get; set; } = null;
    }
}
