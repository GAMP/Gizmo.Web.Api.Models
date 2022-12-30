using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for host layout groups.
    /// </summary>
    [MessagePackObject]
    public sealed class HostLayoutGroupsFilter : IFilterModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return layout groups with names that contain the specified string.
        /// </summary>
        [Key(1)]
        public string LayoutGroupName { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(2)]
        public List<string> Expand { get; set; }

        #endregion
    }
}
