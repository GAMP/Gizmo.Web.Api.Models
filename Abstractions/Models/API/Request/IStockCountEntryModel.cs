namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count entry model.
    /// </summary>
    public interface IStockCountEntryModel : IWebApiModel
    {
        /// <summary>
        /// Product id.
        /// </summary>
        int ProductId { get; init; }

        /// <summary>
        /// Actual.
        /// </summary>
        decimal Actual { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        public string? Note { get; init; }
    }
}
