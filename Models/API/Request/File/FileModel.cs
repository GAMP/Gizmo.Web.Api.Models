using System;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IFileModel"/>
    [MessagePack.MessagePackObject]
    public sealed class FileModel : IFileModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public string FileName { get; init; } = null!;
        
        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string MimeType { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public Guid Guid { get; init; }
    }
}
