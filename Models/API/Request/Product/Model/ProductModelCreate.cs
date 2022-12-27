using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Model
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductModelCreate : ProductModelBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the product.
        /// </summary>
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(100)]
        public ProductType ProductType { get; set; }

        #endregion
    }
}