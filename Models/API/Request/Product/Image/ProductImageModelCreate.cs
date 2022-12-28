using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Image
{
    /// <summary>
    /// Product image.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductImageModelCreate : IProductImageApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}