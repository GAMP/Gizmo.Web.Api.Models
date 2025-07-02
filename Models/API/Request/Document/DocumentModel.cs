using Gizmo.Web.Api.Models.Abstractions;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IDocumentModel"/>
    [MessagePack.MessagePackObject]
    public sealed class DocumentModel : IDocumentModel, IModelIntIdentifier
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

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public Guid Guid { get; init; }

        /// <summary>
        /// Document file size.
        /// </summary>
        [MessagePack.Key(5)]
        public long Size { get; init; }
    }
}
