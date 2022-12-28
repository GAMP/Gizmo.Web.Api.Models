using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Group
{
    /// <summary>
    /// Product group.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroupModelCreate : IProductGroupApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [MessagePack.Key(2)]
        [EnumValueValidation]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}