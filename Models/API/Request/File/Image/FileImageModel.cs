using System;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IFileImageModel"/>
    [MessagePack.MessagePackObject]
    public sealed class FileImageModel : IFileImageModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public Guid Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string FileName { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string MimeType { get; init; } = null!;
    }
}
