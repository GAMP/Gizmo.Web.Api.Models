using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Image
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The image data of the product image.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public byte[] Image { get; set; }

        #endregion
    }
}