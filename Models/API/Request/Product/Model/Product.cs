using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.Product.Image;
using Gizmo.Web.Api.Models.Models.API.Request.Product.PurchaseAvailability;
using Gizmo.Web.Api.Models.Models.API.Request.Product.Tax;
using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Model
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class Product : ProductModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The type of the product.
        /// </summary>
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(101)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [MessagePack.Key(102)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The taxes of the product.
        /// </summary>
        [MessagePack.Key(103)]
        public IEnumerable<ProductTax> ProductTaxes { get; set; }

        /// <summary>
        /// The images of the product.
        /// </summary>
        [MessagePack.Key(104)]
        public IEnumerable<ProductImage> ProductImages { get; set; }

        /// <summary>
        /// The purchase availability of the product.
        /// </summary>
        [MessagePack.Key(105)]
        public ProductPurchaseAvailability ProductPurchaseAvailability { get; set; }

        #endregion
    }
}