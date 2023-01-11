namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Image.
    /// </summary>
    public interface IImageApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        byte[] Image { get; set; }
    }
}