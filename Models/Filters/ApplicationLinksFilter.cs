using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application link.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationLinksFilter : IModelFilter<ApplicationLinkModel>
    {
        #region PROPERTIES

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
        /// Return links that belongs to the specified application.
        /// </summary>
        [Key(3)]
        public int? ApplicationId { get; set; }

        #endregion
    }
}
