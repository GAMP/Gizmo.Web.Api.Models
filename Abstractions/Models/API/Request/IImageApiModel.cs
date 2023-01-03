namespace Gizmo.Web.Api.Models.Abstractions
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