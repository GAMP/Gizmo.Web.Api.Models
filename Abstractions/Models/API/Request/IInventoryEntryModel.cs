using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry model.
    /// </summary>
    public interface IInventoryEntryModel : IWebApiModel , IModelIntIdentifier
    {
        /// <summary>
        /// Inventory id.
        /// </summary>
        public int InventoryId { get; }

        /// <summary>
        /// Gets or sets the stock id.
        /// </summary>
        public int StockId { get;  }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public int ProductId { get; }

        /// <summary>
        /// Gets or sets the stock transaction id.
        /// </summary>
        public int StockTransactionId { get; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public decimal Quantity { get; }
    }
}
