﻿using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch filter model. 
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchFilter : IModelFilter<BranchModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Branch name.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Name { get; init; } 
    }
}
