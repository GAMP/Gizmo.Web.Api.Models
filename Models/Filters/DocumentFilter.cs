using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DocumentFilter : IModelFilter<DocumentModel>
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filter by document type id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? DocumentTypeId { get; init; }

        /// <summary>
        /// Filter by deleted state.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDeleted { get; init; }
    }
}
