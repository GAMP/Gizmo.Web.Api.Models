using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client task filter.
    /// </summary>
    [MessagePackObject]
    public sealed class ClientTaskFilter : IModelFilter<ClientTaskModel>
    {
        /// <inheritdoc/>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Activation.
        /// </summary>
        [Key(2)]
        public int? Activation { get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [Key(3)]
        public bool? IsEnabled { get; init; }
    }
}
