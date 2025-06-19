namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count entry model create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockCountEntryModelCreate : IWebApiModel, IStockCountEntryModel
    {
        /// <inheritdoc/>
        public int ProductId { get; init; }

        /// <inheritdoc/>
        public decimal Actual { get; init; }

        /// <inheritdoc/>
        public string? Note { get; init; }
    }
}
