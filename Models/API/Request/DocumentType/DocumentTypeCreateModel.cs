namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Document type create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class DocumentTypeCreateModel : IDocumentTypeModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;
    }
}
