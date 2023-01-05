﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product group.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroupModelUpdate : IProductGroupApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the product group.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The display order of the product group.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The sort option of the product group.
        /// </summary>
        [MessagePack.Key(3)]
        [EnumValueValidation]
        public ProductSortOptionType SortOption { get; set; }

        #endregion
    }
}