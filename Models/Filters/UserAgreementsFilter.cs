﻿#nullable enable

using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user agreements.
    /// </summary>
    [MessagePackObject]
    public sealed class UserAgreementsFilter : IFilterApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; } = new();

        /// <summary>
        /// Return enabled user agreements.
        /// </summary>
        [Key(1)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(2)]
        public List<string> Expand { get; set; } = new();

        #endregion
    }
}