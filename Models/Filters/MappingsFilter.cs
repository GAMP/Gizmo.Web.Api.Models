using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mappings filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class MappingsFilter : IModelFilter<MappingModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Mapping type.
        /// </summary>
        [MessagePack.Key(2)]
        public MappingType? Type { get; set; }
    }
}
