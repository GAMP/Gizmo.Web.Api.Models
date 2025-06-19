namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count entry model create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockCountEntryModelCreate : IWebApiModel, IStockCountEntryModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public decimal Actual { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Note { get; init; }
    }
}
