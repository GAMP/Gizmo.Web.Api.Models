using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Image
{
    /// <summary>
    /// Product image.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductImageModelUpdate : IProductImageApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this image belongs to.
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [MessagePack.Key(2)]
        public byte[] Image { get; set; }

        #endregion
    }
}