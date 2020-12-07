using Gizmo;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for products.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return products of the specified product type.
        /// </summary>
        [DataMember]
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// Return products that belongs to the specified product group.
        /// </summary>
        [DataMember]
        public int? ProductGroup { get; set; }

        /// <summary>
        /// Return products with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string ProductName { get; set; }

        /// <summary>
        /// Return deleted products.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        #endregion
    }
}
