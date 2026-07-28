using Gizmo.Web.Api.Models.Abstractions;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IFileImageModel"/>
    [MessagePack.MessagePackObject]
    public sealed class FileImageModel : IFileImageModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string FileName { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public Guid Guid { get; init; }

        /// <summary>
        /// File image file size.
        /// </summary>
        [MessagePack.Key(3)]
        public long Size { get; init; }

        /// <summary>
        /// Content type recorded at upload; null on legacy rows uploaded before
        /// content detection.
        /// </summary>
        [MessagePack.Key(4)]
        public string? MimeType { get; init; }
    }
}
