using System;
using System.Collections.Generic;
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
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public TimeProduct TimeProduct { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        [DataMember]
        public Bundle Bundle { get; set; }

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