namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document type model.
    /// </summary>
    public interface IDocumentTypeModel : IWebApiModel
    {
        /// <summary>
        /// Document type name.
        /// </summary>
        public string Name { get; init; }
    }
}
