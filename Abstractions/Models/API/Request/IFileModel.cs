namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File model.
    /// </summary>
    public interface IFileModel : IWebApiModel
    {
        /// <summary>
        /// File name.
        /// </summary>
        public string FileName { get; init; }
    }
}
