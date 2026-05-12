using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory inbound entry create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryInboundEntryModelCreate : IInventoryEntryModelCreate
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public decimal Quantity { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Note { get; init; }

        /// <summary>
        /// Unit cost.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal UnitCost { get; init; }

        /// <summary>
        /// Expiration date (UTC).
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? ExpirationDate { get; init; }
    }
}
