using Gizmo.Web.Api.Models.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line creation model.
    /// </summary>
    /// <remarks>
    /// This model will be posted as part of order creation model.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class OrderLineCreateModel : IUriParametersQuery
    {
        /// <summary>
        /// Optional order line model guid.
        /// </summary>
        /// <remarks>
        /// This parameter can be used to identify order line in the cart.
        /// </remarks>
        [MessagePack.Key(0)]
        public Guid? Guid { get; set; }

        /// <summary>
        /// The type of the order line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public LineType LineType { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Whether to use the custom price for this order line. 
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsCustomPrice { get; set; }

        /// <summary>
        /// The custom price of the order line.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal? CustomPrice { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(4)]
        public OrderLineProductModel? Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(5)]
        public OrderLineProductModel? TimeProduct { get; set; }

        /// <summary>
        /// The fixed time object attached to this order line if the order line refers to fixed time, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(6)]
        public OrderLineFixedTimeModel? FixedTime { get; set; }

        /// <summary>
        /// The mark if the product is marked product.
        /// </summary>
        [MessagePack.Key(7)]
        public string? Mark { get; set; }
    }
}
