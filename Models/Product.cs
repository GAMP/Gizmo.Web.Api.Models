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
    public class Product : ProductModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The type of the product.
        /// </summary>
        [DataMember]
        [Required]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// The images of the product.
        /// </summary>
        [DataMember]
        public IEnumerable<ProductImage> ProductImages { get; set; }

        /// <summary>
        /// The purchase availability of the product.
        /// </summary>
        [DataMember]
        public ProductPurchaseAvailability ProductPurchaseAvailability { get; set; }

        #endregion
    }
}