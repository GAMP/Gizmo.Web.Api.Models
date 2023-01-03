﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for asset transactions.
    /// </summary>
    [MessagePackObject]
    public sealed class AssetTransactionsFilter : IFilterApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; } = new();

        /// <summary>
        /// Return asset transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(1)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return asset transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(2)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return asset transactions of the specified user.
        /// </summary>
        [Key(3)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return active asset transactions.
        /// </summary>
        [Key(4)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(5)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}
