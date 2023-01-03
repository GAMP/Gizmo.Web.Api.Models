﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for products.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductsFilter : IFilterApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [MessagePack.Key(0)]
        public PaginationFilter PaginationFilter { get; set; } = new();

        /// <summary>
        /// Return products of the specified product type.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(1)]
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// Return products that belongs to the specified product group.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ProductGroupId { get; set; }

        /// <summary>
        /// Return products with names that contain the specified string.
        /// </summary>
        [MessagePack.Key(3)]
        public string ProductName { get; set; } = null!;

        /// <summary>
        /// Return deleted products.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(5)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
