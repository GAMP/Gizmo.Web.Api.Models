using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory create model contract.
    /// </summary>
    public interface IInventoryModelCreate
    {
        /// <summary>
        /// Stock id.
        /// </summary>
        int StockId { get; }

        /// <summary>
        /// Note.
        /// </summary>
        string? Note { get; }

        /// <summary>
        /// Inventory associated documents.
        /// </summary>
        IEnumerable<int> Documents { get; }

        /// <summary>
        /// Inventory entries.
        /// </summary>
        IEnumerable<IInventoryEntryModelCreate> Entries { get; }
    }
}
