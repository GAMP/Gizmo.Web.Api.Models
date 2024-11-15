namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry model.
    /// </summary>
    public interface IInventoryEntryModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the stock id.
        /// </summary>
        public int StockId { get; init; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public int ProductId { get; init; }

        /// <summary>
        /// Gets or sets the stock transaction id.
        /// </summary>
        public int StockTransactionId { get; init; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public decimal Quantity { get; init; }
    }
}
