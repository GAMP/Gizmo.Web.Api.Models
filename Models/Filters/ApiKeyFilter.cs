using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Api key filter model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ApiKeyFilter : IModelFilter<ApiKeyModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Is deleted.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDisabled { get; set; }
    }
}
