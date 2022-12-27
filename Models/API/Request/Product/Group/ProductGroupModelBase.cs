using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Group
{
    /// <summary>
    /// Product group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(2)]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}
