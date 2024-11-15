using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DocumentUpdateModel : IDocumentModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int DocumentTypeId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string FileName { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public string? Description { get; init; }
    }
}
