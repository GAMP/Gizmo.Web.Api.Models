using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File create model.
    /// </summary>
    /// <remarks>
    /// Travels as query parameters next to the multipart file content.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class FileCreateModel : IFileModel, IUriParametersQuery
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public string FileName { get; init; } = null!;
    }
}
