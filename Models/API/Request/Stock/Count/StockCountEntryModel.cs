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
        public int Id { get; init; }

        /// <inheritdoc/>
        public int ProductId { get; init; }

        /// <inheritdoc/>
        public decimal Expected { get; init; }

        /// <inheritdoc/>
        public decimal Actual { get; init; }

        /// <inheritdoc/>
        public decimal Difference { get; init; }
    }
}
