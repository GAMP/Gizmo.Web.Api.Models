using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File model.
    /// </summary>
    /// <remarks>
    /// A file stored without a more specific kind, such as a notification sound.
    /// The content is served at <c>/files/{Guid}</c>; the kind is the content type.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class FileModel : IFileModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string FileName { get; init; } = null!;

        /// <summary>
        /// File guid, the address of the content.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid Guid { get; init; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [MessagePack.Key(3)]
        public long Size { get; init; }

        /// <summary>
        /// Content type detected at upload; null on legacy rows uploaded before
        /// content detection.
        /// </summary>
        [MessagePack.Key(4)]
        public string? MimeType { get; init; }
    }
}
