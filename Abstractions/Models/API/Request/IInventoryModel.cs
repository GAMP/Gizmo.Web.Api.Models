namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory model.
    /// </summary>
    public interface IInventoryModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the stock id.
        /// </summary>
        public int StockId { get; init; }

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        public int? ShiftId { get; init; }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        public string? Note { get; init; }
    }
}
