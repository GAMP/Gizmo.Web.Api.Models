using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductImage : IProductImageApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this image belongs to.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Key(2)]
        public byte[] Image { get; set; }

        #endregion
    }
}