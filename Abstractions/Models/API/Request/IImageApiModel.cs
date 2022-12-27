namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Image.
    /// </summary>
    public interface IImageApiModel
    {
        /// <summary>
        /// The image data.
        /// </summary>
        byte[] Image { get; set; }
    }
}