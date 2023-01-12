using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Abstractions.Models.Filters
{
    /// <summary>
    /// Specified objects in the result.
    /// </summary>
    public interface IModelFIlterOptions : IUriParametersQuery
    {
        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        List<string> Expand { get; set; }
    }
}