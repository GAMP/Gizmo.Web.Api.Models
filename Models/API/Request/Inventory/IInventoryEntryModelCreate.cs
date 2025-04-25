namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry create model contract.
    /// </summary>
    public interface IInventoryEntryModelCreate : IWebApiModel
    {
        /// <summary>
        /// Product id.
        /// </summary>
        public int ProductId { get; }

        /// <summary>
        /// Quantity.
        /// </summary>
        public decimal Quantity { get; }

        /// <summary>
        /// Note.
        /// </summary>
        public string? Note { get; }
    }
}
