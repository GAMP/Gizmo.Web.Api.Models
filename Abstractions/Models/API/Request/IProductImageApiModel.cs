namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Product image.
    /// </summary>
    public interface IProductImageApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The image data of the product image.
        /// </summary>
        byte[] Image { get; set; }
    }
}