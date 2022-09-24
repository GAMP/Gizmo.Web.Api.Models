using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for products.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return products of the specified product type.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(200)]
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// Return products that belongs to the specified product group.
        /// </summary>
        [MessagePack.Key(201)]
        public int? ProductGroupId { get; set; }

        /// <summary>
        /// Return products with names that contain the specified string.
        /// </summary>
        [MessagePack.Key(202)]
        public string ProductName { get; set; }

        /// <summary>
        /// Return deleted products.
        /// </summary>
        [MessagePack.Key(203)]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
