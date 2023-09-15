using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request type update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AssistanceRequestTypeModelUpdate : IAssistanceRequestTypeModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        [StringLength(45)]
        public string Title { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public bool IsDeleted { get; set; }
    }
}
