using Gizmo.Web.Api.Models.Abstractions.Models.Filters;
using MessagePack;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    [MessagePackObject]
    public sealed class GetOptions : IGetOptionsFilterModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(0)]
        public List<string> Expand { get; set; }

        #endregion
    }
}