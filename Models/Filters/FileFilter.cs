using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class FileFilter : IModelFilter<FileModel>
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Filter by deleted state.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsDeleted { get; init; }

        /// <summary>
        /// Filter by file name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? FileName { get; init; }

        /// <summary>
        /// Filter by content type prefix, for example <c>audio/</c> for every sound.
        /// </summary>
        [MessagePack.Key(4)]
        public string? MimeType { get; init; }
    }
}
