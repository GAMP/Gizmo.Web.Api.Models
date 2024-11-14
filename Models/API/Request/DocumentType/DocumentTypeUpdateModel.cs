using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document type update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DocumentTypeUpdateModel : IDocumentTypeModel, IModelIntIdentifier
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;
    }
}
