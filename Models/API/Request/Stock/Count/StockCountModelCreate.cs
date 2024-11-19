using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count model create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockCountModelCreate : IWebApiModel
    {
        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(0)]
        public int StockId { get; init; }

        /// <summary>
        /// Count note.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string? Note { get; init; }

        /// <summary>
        /// Count type.
        /// </summary>
        [MessagePack.Key(2)]
        public StockCountType Type { get; init; }

        /// <summary>
        /// Counts.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<StockCountEntryModelCreate> Counts { get;init; } = Enumerable.Empty<StockCountEntryModelCreate>();
    }
}
