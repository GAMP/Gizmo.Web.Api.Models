namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File image model.
    /// </summary>
    public interface IFileImageModel : IWebApiModel
    {
        /// <summary>
        /// File name.
        /// </summary>
        public string FileName { get; init; }
    }
}
