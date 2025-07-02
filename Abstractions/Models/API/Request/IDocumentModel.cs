namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document model.
    /// </summary>
    public interface IDocumentModel : IWebApiModel
    {
        /// <summary>
        /// Document type id.
        /// </summary>
        public int DocumentTypeId { get; init; }

        /// <summary>
        /// File name.
        /// </summary>
        public string FileName { get; init; }

        /// <summary>
        /// Description.
        /// </summary>
        public string? Description { get; init; }
    }
}
