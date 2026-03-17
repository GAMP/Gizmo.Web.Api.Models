using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File image update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class FileImageUpdateModel : IFileImageModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string FileName { get; init; } = null!;
    }
}
