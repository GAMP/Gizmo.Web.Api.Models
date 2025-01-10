using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DocumentCreateModel : IDocumentModel , IUriParametersQuery
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int DocumentTypeId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string FileName { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Description { get; init; }
    }
}
