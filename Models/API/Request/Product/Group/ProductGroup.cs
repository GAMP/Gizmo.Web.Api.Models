using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Group
{
    /// <summary>
    /// Product group.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroup : IProductGroupApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(3)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [MessagePack.Key(4)]
        [EnumValueValidation]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}