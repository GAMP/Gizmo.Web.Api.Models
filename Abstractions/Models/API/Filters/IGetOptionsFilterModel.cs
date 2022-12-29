using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Filters
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    public interface IGetOptionsFilterModel
    {
        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        List<string> Expand { get; set; }
    }
}