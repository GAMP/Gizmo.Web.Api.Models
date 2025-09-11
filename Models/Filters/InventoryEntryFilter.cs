using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryEntryFilter : IModelFilter<InventoryEntryModel>
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();
    }
}
