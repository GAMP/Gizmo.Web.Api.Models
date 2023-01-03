namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Host icon.
    /// </summary>
    public interface IHostIconApiModel
    {
        /// <summary>
        /// The image data of the host icon.
        /// </summary>
        byte[] Image { get; set; }
    }
}