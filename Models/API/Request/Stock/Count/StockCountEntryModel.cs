using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count entry model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockCountEntryModel : IStockCountEntryModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int ProductId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public decimal Expected { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public decimal Actual { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public decimal Difference { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        [MaxLength(255)]
        public string? Note { get; init; }
    }
}
