using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product order line.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLineCreateTimeProductModel : IOrderLineCreateModel
    {
        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        public LineType Type => LineType.TimeProduct;

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// The Id of the time product.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; set; }
    }
}
