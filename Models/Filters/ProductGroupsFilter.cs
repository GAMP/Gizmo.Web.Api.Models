using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.API.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for product groups.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductGroupsFilter : IFilterModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return groups with names that contain the specified string.
        /// </summary>
        [Key(2)]
        public string GroupName { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(3)]
        public List<string> Expand { get; set; }

        #endregion
    }
}
