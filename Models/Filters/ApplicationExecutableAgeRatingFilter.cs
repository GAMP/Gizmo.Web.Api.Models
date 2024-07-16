using System;
using System.Collections.Generic;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application executable age ratings.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutableAgeRatingFilter : IModelFilterClassic<ApplicationExecutableAgeRatingModel>
    {
        /// <inheritdoc />
        [Key(0)]
        public ModelFilterPaginationClassic Pagination { get; set; } = new();

        /// <inheritdoc />
        [Key(1)]
        public List<string> Expand { get; set; } = [];
    }
}
