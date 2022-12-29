using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.API.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for monetary units.
    /// </summary>
    [MessagePackObject]
    public sealed class MonetaryUnitsFilter : IFilterModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return deleted monetary units.
        /// </summary>
        [Key(1)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [MessagePack.Key(2)]
        public List<string> Expand { get; set; }

        #endregion
    }
}