using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File image create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class FileImageCreateModel : IFileImageModel , IUriParametersQuery
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public string FileName { get; init; } = null!;
    }
}
