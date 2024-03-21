using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fixed time order line.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLineCreateFixedTime : IOrderLineCreateModel
    {
        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        public OrderLineCreateType Type =>  OrderLineCreateType.FixedTime;

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// The quantity type of the fixed time line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public FixedTimeQuantityType QuantityType { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Whether to use the custom price for this order line. 
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsCustomPrice { get; set; }

        /// <summary>
        /// The custom price of the order line.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal? CustomPrice { get; set; }
    }
}
