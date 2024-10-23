using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for time products.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class TimeProductsFilter : IModelFilter<NewsModel>
    {
        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Return time products of the specified user.
        /// </summary>
        [Key(2)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return time products of the specified status.
        /// </summary>
        [Key(3)]
        public TimeProductStatus? Status { get; set; }

    }
}
