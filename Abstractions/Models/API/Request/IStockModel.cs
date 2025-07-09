namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock model.
    /// </summary>
    public interface IStockModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Gets or sets stock type.
        /// </summary>
        public StockType Type { get; init; }

        /// <inheritdoc/>
        public int? BranchId { get; init; }

        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
