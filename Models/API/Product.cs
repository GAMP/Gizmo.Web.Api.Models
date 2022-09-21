using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class Product : ProductModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The type of the product.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(101)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The taxes of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(103)]
        public IEnumerable<ProductTax> ProductTaxes { get; set; }

        /// <summary>
        /// The images of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(104)]
        public IEnumerable<ProductImage> ProductImages { get; set; }

        /// <summary>
        /// The purchase availability of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(105)]
        public ProductPurchaseAvailability ProductPurchaseAvailability { get; set; }

        #endregion
    }
}