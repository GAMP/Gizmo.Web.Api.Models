using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory inbound create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryInboundModelCreate : IInventoryModelCreate
    {
        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(0)]
        public int StockId { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string? Note { get; init; }

        /// <summary>
        /// Documents.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<int> Documents { get; init; } = Enumerable.Empty<int>();

        /// <inheritdoc cref="IInventoryModelCreate.Entries"/>
        [MessagePack.Key(3)]
        public IEnumerable<InventoryInboundEntryModelCreate> Entries { get; init; } = Enumerable.Empty<InventoryInboundEntryModelCreate>();

        /// <inheritdoc/>
        IEnumerable<IInventoryEntryModelCreate> IInventoryModelCreate.Entries => Entries;
    }
}
