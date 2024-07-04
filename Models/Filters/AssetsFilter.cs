﻿using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for assets.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AssetsFilter : IModelFilter<AssetModel> , IBranchBasedModelFilter
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Return assets with tags that contain the specified string.
        /// </summary>
        [Key(1)]
        public string? Tag { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(2)]
        public List<string> Expand { get; set; } = new();

        /// <inheritdoc/>
        [Key(3)]
        public int? BranchId { get; set; }

        #endregion
    }
}
