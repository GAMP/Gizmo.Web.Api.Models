using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document type filter model.
    /// </summary>
    public sealed class DocumentTypeFilter : IModelFilter<DocumentTypeModel>
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
        /// Whether to select only deleted document types.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsDeleted { get; set; }
    }
}
