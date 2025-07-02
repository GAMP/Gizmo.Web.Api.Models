using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory transfer create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryTransferModelCreate : IInventoryModelCreate
    {
        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(0)]
        public int StockId { get; init; }

        /// <summary>
        /// Transfer stock id.
        /// </summary>
        [MessagePack.Key(1)]
        public int TransferStockId { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? Note { get; init; }

        /// <summary>
        /// Documents.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<int> Documents { get; init; } = Enumerable.Empty<int>();

        /// <inheritdoc cref="IInventoryModelCreate.Entries"/>
        [MessagePack.Key(4)]
        public IEnumerable<InventoryTransferEntryModelCreate> Entries { get; init; } = Enumerable.Empty<InventoryTransferEntryModelCreate>();

        /// <summary>
        /// Automatic transfer.
        /// </summary>
        [MessagePack.Key(5)]
        public bool AutoInbound { get; init; }

        /// <inheritdoc/>
        IEnumerable<IInventoryEntryModelCreate> IInventoryModelCreate.Entries => Entries;
    }
}
