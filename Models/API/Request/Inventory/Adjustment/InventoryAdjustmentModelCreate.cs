using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryAdjustmentModelCreate : IInventoryModelCreate
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

        /// <summary>
        /// Adjustment type.
        /// </summary>
        [MessagePack.Key(3)]
        public InventoryAdjustmentType AdjustmentType { get; init; }

        /// <inheritdoc cref="IInventoryModelCreate.Entries"/>
        [MessagePack.Key(4)]
        public IEnumerable<InventoryAdjustmentEntryModelCreate> Entries { get; init; } = Enumerable.Empty<InventoryAdjustmentEntryModelCreate>();

        /// <inheritdoc/>
        IEnumerable<IInventoryEntryModelCreate> IInventoryModelCreate.Entries => Entries;
    }
}
